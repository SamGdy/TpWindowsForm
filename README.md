# Mon éditeur
Présentation du projet : l'objectif est de réaliser un éditeur de texte capable des fonctionlités de base. 

Les outils mis en oeuvre :
* visual studio
* bibliotheque WindowsForm
* bibliotheque System.IO

Le développement tourne autour de 2 parties principales :
1. La gestion du texte 
2. L'enregistrement

|Développement  |langages |Technique de programmation   |
|--|:---:|---|
|Gestion du texte|C#|Programmation objet tests unitaires|
|Enregistrement |C#,system.IO|---|

# La gestion du texte
Afin de pouvoir gérer le texte, on ajoute des méthodes pour mettre en place les outils de base d'un éditeur.
Comme les outils : copier/coller, couper, undo(retour en arrière) ...
L'éditeur ressemble à cela :

![MonEditeur.png](https://github.com/SamGdy/TpWindowsForm/blob/master/MonEditeur.PNG)

# L'enregistrement
En utilisant la bibliothèque IO (input,output) on developpe les méthodes qui permettent d'enregistrer ou de charger un fichier.
