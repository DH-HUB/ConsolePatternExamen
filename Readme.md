         Gestion des �tats de mat�riels des �coles IFA et MNS


Pr�sentation:

Ce programme est con�u pour afficher les mouvements des �tats de mat�riels (emprunt�, en r�paration, non r�parable et en stock disponible) pour les �coles MNS et IFA. Le programme utilise les design patterns Composite, Command et Decorator pour la gestion des affiliations d'�coles et de stagiaires, la gestion des �tats de mat�riels et l'enrichissement de l'affichage avec des informations suppl�mentaires.

Description du programme:

Le programme utilise l'interface IAffiliate pour d�finir une interface commune pour les �coles et les stagiaires, qui sont les affiliations des �coles MNS et IFA. Il utilise �galement les classes MNS, IFA et Stagiaire  pour impl�menter ces affiliations.
Le programme utilise �galement l'interface ICommand pour d�finir une interface commune pour les commandes qui modifient l'�tat du mat�riel. Les classes BorrowedState, RepairingState, NonReparableState et AvailableState impl�mentent cette interface et sont utilis�es pour d�finir les diff�rents �tats du mat�riel.
Le programme utilise �galement les classes Material et MaterialDecorator pour impl�menter le pattern Decorator. La classe Material d�finit le mat�riel et son �tat, tandis que la classe MaterialDecorator ajoute des informations suppl�mentaires � l'affichage du mat�riel.
Dans la classe Program, une instance de l'�cole MNS est cr��e et trois stagiaires y sont ajout�s. Ensuite, un mat�riel est cr�� avec des informations suppl�mentaires (dur�e et photo) en utilisant les classes DurationDecorator et PhotoDecorator. L'�tat du mat�riel est modifi� � l'aide de diff�rentes commandes et l'affichage du mat�riel est mis � jour avec les informations suppl�mentaires � chaque �tape.

Utilisation du programme:

Le programme est une simple application console  d�velopp�e en C#. Il est con�u dans le but d'employer les trois design patterns (Composite, Command et Decorator) dans le contexte de gestion des �tats du mat�riel des �coles IFA et MNS. Pour ex�cuter le programme, il suffit de lancer l'application console et de suivre les instructions affich�es � l'�cran. Le programme permet de voir l'�volution des �tats des mat�riels emprunt�s par les stagiaires des �coles IFA et MNS.

Auteurs:

Le programme a �t� d�velopp� par  [Hakima Djermouni]  dans le cadre d'un projet de design patterns.


