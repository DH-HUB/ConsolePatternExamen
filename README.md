         					Gestion des états de matériels des écoles IFA et MNS


Présentation:

Ce programme est conçu pour afficher les mouvements des états de matériels (emprunté, en réparation, non réparable et en stock disponible) pour les écoles MNS et IFA. Le programme utilise les design patterns Composite, Command et Decorator pour la gestion des affiliations d'écoles et de stagiaires, la gestion des états de matériels et l'enrichissement de l'affichage avec des informations supplémentaires.

Description du programme:

Le programme utilise l'interface IAffiliate pour définir une interface commune pour les écoles et les stagiaires, qui sont les affiliations des écoles MNS et IFA. Il utilise également les classes MNS, IFA et Stagiaire  pour implémenter ces affiliations.
Le programme utilise également l'interface ICommand pour définir une interface commune pour les commandes qui modifient l'état du matériel. Les classes BorrowedState, RepairingState, NonReparableState et AvailableState implémentent cette interface et sont utilisées pour définir les différents états du matériel.
Le programme utilise également les classes Material et MaterialDecorator pour implémenter le pattern Decorator. La classe Material définit le matériel et son état, tandis que la classe MaterialDecorator ajoute des informations supplémentaires à l'affichage du matériel.
Dans la classe Program, une instance de l'école MNS est créée et trois stagiaires y sont ajoutés. Ensuite, un matériel est créé avec des informations supplémentaires (durée et photo) en utilisant les classes DurationDecorator et PhotoDecorator. L'état du matériel est modifié à l'aide de différentes commandes et l'affichage du matériel est mis à jour avec les informations supplémentaires à chaque étape.

Utilisation du programme:

Le programme est une simple application console  développée en C#. Il est conçu dans le but d'employer les trois design patterns (Composite, Command et Decorator) dans le contexte de gestion des états du matériel des écoles IFA et MNS. Pour exécuter le programme, il suffit de lancer l'application console et de suivre les instructions affichées à l'écran. Le programme permet de voir l'évolution des états des matériels empruntés par les stagiaires des écoles IFA et MNS.

Auteurs:

Le programme a été développé par  [Hakima Djermouni]  dans le cadre d'un projet de design patterns.


