// See https://aka.ms/new-console-template for more information
using ConsolePatternExamen;

class Program
{
    static void Main(string[] args)
    {
        // Création de l'école MNS
        MNS mns = new MNS();
        mns.Add(new Stagiaire("Hakima"));
        mns.Add(new Stagiaire("Eliana"));
        mns.Add(new Stagiaire("Elia"));
        // Affichage des affiliations
        mns.Display();

        /*Le programme utilise l'interface `IAffiliate` pour définir une interface commune pour les écoles et les stagiaires, qui sont les affiliations des écoles MNS et IFA. 
         *Il utilise également les classes `MNS`, `IFA` et `Trainee` pour implémenter ces affiliations.
         *Le programme utilise également l'interface `ICommand` pour définir une interface commune pour les commandes qui modifient l'état du matériel. 
         *Les classes `BorrowedState`, `RepairingState`, `NonReparableState` et `AvailableState` implémentent cette interface et sont utilisées pour définir les différents états du matériel.
         *Le programme utilise également les classes `Material` et `MaterialDecorator` pour implémenter le pattern Decorator. La classe `Material` définit le matériel et son état,
         *tandis que la classe `MaterialDecorator` ajoute des informations supplémentaires à l'affichage du matériel.
         *Dans le programme principal, une instance de l'école MNS est créée et trois stagiaires y sont ajoutés. 
         *Ensuite, un matériel est créé avec des informations supplémentaires (durée et photo) en utilisant les classes `DurationDecorator` et `PhotoDecorator`. 
         *L'état du matériel est modifié à l'aide de différentes commandes et l'affichage du matériel est mis à jour avec les informations supplémentaires à chaque étape.*/

        // Création d'un matériel avec informations supplémentaires
        Material material = new Material("Ordinateur");
        MaterialDecorator materialWithDuration = new DurationDecorator(material, "2 semaines");
        MaterialDecorator materialWithPhoto = new PhotoDecorator(materialWithDuration, "photo.png");

        // Changement d'état du matériel
        materialWithPhoto.Display();
        materialWithPhoto.ChangeState(new BorrowedState(material));
        materialWithPhoto.Display();
        materialWithPhoto.ChangeState(new RepairingState(material));
        materialWithPhoto.Display();
        materialWithPhoto.ChangeState(new NonReparableState(material));
        materialWithPhoto.Display();

        // Création des affiliations
        //MNS mns = new MNS();
        IFA ifa = new IFA();
        Stagiaire stagiaire1 = new Stagiaire("Trainee 1");
        Stagiaire stagiaire2 = new Stagiaire("Trainee 2");
        // Ajout des affiliations et des stagiaires
        mns.Add(stagiaire1);
        mns.Add(stagiaire2);
        mns.Add(ifa);

        // Affichage des affiliations et des stagiaires
        mns.Display();

        // Création des matériels
        Material material1 = new Material("Material 1");
        Material material2 = new Material("Material 2");

        // Affichage des états initiaux des matériels
        material1.DisplayState();
        material2.DisplayState();

        // Changement d'état du premier matériel et affichage
        material1.ChangeState(new BorrowedState(material1));
        material1.DisplayState();

        // Changement d'état du deuxième matériel et affichage avec information supplémentaire
        material2 = new AdditionalInfoDecorator(material2, "Durée de réparation estimée : 3 jours");
        material2.ChangeState(new RepairingState(material2));
        material2.DisplayState();

        Console.ReadLine();
    }
}



