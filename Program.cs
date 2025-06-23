// See https://aka.ms/new-console-template for more information

// 1.Écrire un programme qui vérifie si un nombre donné est supérieur à 10.
/*
int? input;
Console.WriteLine("Veuillez entrer un nombre: ");
input = Convert.ToInt32(Console.ReadLine());

if (input > 10)
{
    Console.WriteLine($"{input}, est superieur à 10");
}
else if (input < 10)
{
    Console.WriteLine($"{input}, est inférieur à 10 !");
}
else
{
    Console.WriteLine($"{input} est équivalent à 10");
};
*/

// 2. Vérifier si un nombre donné est positif, négatif ou nul.

/*
int? input;
Console.WriteLine("Veuillez entrer un nombre: ");
input = Convert.ToInt32(Console.ReadLine());
if (input > 0)
{
    Console.WriteLine($"{input}, est positif");
}
else if (input < 0)
{
    Console.WriteLine($"{input}, est négatif !");
}
else if (!input.HasValue)
{
    Console.WriteLine($"{input} est nulle");
}
;
*/
/*
int n = 12;
switch (n)
{
    case > 0:
        Console.WriteLine("pos");
        break;
    case < 0:
        Console.WriteLine("neg");
        break;
    case 0:
        Console.WriteLine("0");
        break;
          
}
*/

// 3.Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18.

/*
int? age = null;

Console.WriteLine("Veuillez entrer votre âge: ");
age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("You can enter in the discotheque!");
}
else
{
    Console.WriteLine("You are under 18.");
}
*/

// 4. Écrire un programme qui vérifie si une chaîne de caractères est vide ou non.
/*
string input;
Console.WriteLine("Enter a string: ");
if (Console.ReadLine() == "")
{
    Console.WriteLine("This string is empty.");
}
*/

// 5. Vérifier si un nombre est pair ou impair.
/*
Console.WriteLine("Enter a number: ");
int? input = Convert.ToInt32(Console.ReadLine());
if (input % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
*/
// 6. Écrire un programme qui compare deux nombres et affiche le plus grand.
/*
Console.WriteLine("Enter number 1: ");
int? num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int? num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("num1 est plus grand.");
}
else if (num1 < num2)
{
    Console.WriteLine("num2 est plus grand");
}
else
{
    Console.WriteLine("Ils sont égaux");
}
*/
// 7. Vérifier si un nombre est divisible par 3 ou par 5.
/*
Console.WriteLine("Enter a number: ");
int? input = Convert.ToInt32(Console.ReadLine());
if (input % 3 == 0 || input % 5 == 0)
{
    Console.WriteLine("Divisible by 3 or 5.");
}
else
{
    Console.WriteLine("It is not divisible by 3 or 5.");
};
*/
// 8. Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin".
/*
Console.WriteLine("Enter an account: ");
if (Console.ReadLine() == "admin")
{
    Console.WriteLine("It correspond to 'admin'");
}
else
{
    Console.WriteLine("It doesn't correspond to 'admin'");
}
*/

// 9. Créer un programme qui vérifie si une lettre est une voyelle ou une consonne.
/*
const string voyelles = "aeiou";
Console.WriteLine("enter a character: ");
string letter = Console.ReadLine();
foreach(char c in voyelles)
{
    if (c == letter[0])
    {
        Console.WriteLine("voyelle!");
        return;
    }
}
Console.WriteLine("consonne!");
*/

// 10. Calculer le nombre de caractères dans une chaîne de caractères,
// si le nombre de caractères est supérieur à 5, ne garder que les 5 premiers caractères.
/*
Console.WriteLine("Enter a string: ");
string? input = Console.ReadLine();
if (input == null) return;
string output = input.Length > 5 ? input.Substring(0,5) : input;
Console.WriteLine($"Votre string est: {output}");
;
*/

// 11.Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.
/*
Console.WriteLine("Saisir un nombre: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(input > 10 && input < 20);
*/
// 12. Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).
/*
Console.WriteLine("Saisir votre age: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(input < 12 ? "enfant" : input > 18 ? "adulte" : "ado");
*/
// 13. Créer un programme qui vérifie si une année est bissextile ou non.

/*
Console.WriteLine("Saisir une année: ");
int annee = Convert.ToInt32(Console.ReadLine());
if ( annee % 4 == 0 && annee % 100 != 0) 
    Console.WriteLine("bissextile"); 
else Console.WriteLine("pas bis");
*/

// 14. Vérifier si un nombre est positif et multiple de 5.

/*
Console.WriteLine("Saisir un nombre: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(input > 0 && input % 5 == 0);
*/

// 15. Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.
/*
Console.WriteLine("Saisir une string: ");
string? input = Console.ReadLine();
Console.WriteLine(input.Contains('a'));
*/
// 16. Vérifier si un nombre est divisible à la fois par 2 et par 3, mais pas par 9.
/*
Console.WriteLine("Saisir un nombre: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(input % 2 == 0 && input % 3 == 0 && input % 9 != 0);
*/
// 17. Demander à l'utilisateur un nom d'utilisateur et un mot de passe, et vérifier si les deux sont corrects.

/*
Console.WriteLine("Saisir un nom: ");
string name = Console.ReadLine();

Console.WriteLine("Saisir un mdp: ");
string password = Console.ReadLine();

Console.WriteLine(name == password);
*/

// 18. Écrire un programme qui affiche "Excellent" si la note est supérieure à 85, "Bien" si elle est entre 70 et 85, sinon afficher "Peut mieux faire".
/*
Console.WriteLine("Votre note: ");
int note = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(note > 85 ? "Excellent" : note >= 70 ? "Bien" : "Peut mieux faire");
*/

// 19. Créer un programme qui vérifie si une chaîne de caractères est un palindrome.

/*
Console.WriteLine("Saisir un palindrome: ");
string? name = Console.ReadLine();
string reverse = new string(name.Reverse().ToArray());
Console.WriteLine(name == reverse);
*/

// 20.Écrire un programme qui vérifie si un nombre est à la fois positif, pair et supérieur à 100.

/*
Console.WriteLine("Saisir un nombre: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number > 0 && number % 2 == 0 && number > 100);
*/


// 21.Afficher les nombres de 1 à 10 avec une boucle `for`.
/*
for (int i = 1; i <= 10; i++) Console.WriteLine(i);
*/
// 22. Afficher les nombres pairs entre 1 et 20.
/*
for (int i = 1; i <= 20; i++) if (i % 2 == 0) Console.WriteLine(i);
*/
// 23. Utiliser une boucle pour afficher chaque élément d'un tableau.
/*
int[] nombres = { 1, 2, 3, 4, 5 };

foreach(int nombre in nombres) Console.WriteLine(nombre);
*/

// 24. Demander à l'utilisateur un nombre de 1 à 10 et afficher la table de multiplication.
/*
int number;
do
{
    Console.WriteLine("Saisir un nombre entre 1 et 10: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number < 1 || number > 10);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(number * (i + 1));
}
*/
// 25. Afficher les éléments d'une chaîne de caractères un par un.
/*
Console.WriteLine("Saisir une string: ");
string? chaine = Console.ReadLine();
foreach (char c in chaine) Console.WriteLine(c);
*/
// 26. Utiliser une boucle pour afficher les nombres de 0 à 100 avec un pas de 10.
/*
for (int i = 0; i <= 100; i=i+10) Console.WriteLine(i);
*/
// 27. Afficher les éléments d'une liste avec leurs indices.
/*
string[] list = { "a", "b", "c", "d", "e" };
for (int i = 0; i < list.Length; i++) Console.WriteLine($"element {i} : {list[i]}");
*/
// 28. Afficher les nombres de 10 à 1 en ordre décroissant avec une boucle.
/*
for (int i = 10; i > 0; i--) Console.WriteLine(i);
*/
// 29. Créer une boucle qui calcule la somme des nombres de 1 à 50.
/*
int somme = 0;
for (int i = 1; i <= 50; i++)
{
    somme += i;
}
Console.WriteLine(somme);
*/
// 30. Utiliser une boucle pour afficher les 5 premières lettres de l'alphabet
/*
for (int i = 0; i < 5; i++) Console.WriteLine((char)(i + 97));
*/

// 31.Utiliser une boucle `while` pour afficher les nombres de 1 à 10.
/*
int i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}
*/
// 32. Utiliser une boucle `while` pour calculer la somme des nombres de 1 à 100.
/*
int i = 1;
int somme = 0;
while (i <= 100)
{
    somme += i;
    i++;
}
Console.WriteLine(somme);
*/

// 33. Demander à l'utilisateur un nombre et continuer à demander tant que ce nombre est négatif.
/*
int input;
do
{
    Console.WriteLine("enter a positive: ");
    input = Convert.ToInt32(Console.ReadLine());
} while (input < 0);
Console.WriteLine("nombre positif");
*/

// 34. Créer une boucle infinie qui demande un mot de passe jusqu'à ce qu'il soit correct.
/*
string password = "toto";
string input;
do
{
    Console.WriteLine("enter a password:");
    input = Console.ReadLine();
} while (input != password);
*/

// 35. Utiliser `while` pour afficher les multiples de 5 entre 1 et 50.
/*
int i = 1;
while (i <= 50)
{
    Console.WriteLine(i * 5);
    i++;
}
*/

// 36. Écrire une boucle qui affiche les nombres de 1 à 10, puis termine avec un message "Fin de la boucle".
/*
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Fin de la boucle");
*/
// 37. Créer une boucle `while` qui décrémente un nombre à partir de 10 jusqu'à 0.
/*
int i = 10;
while (i >= 0)
{
    Console.WriteLine(i);
    i--;
}
*/
// 38. Demander un nombre à l'utilisateur et calculer sa factorielle avec une boucle `while`.
/*
int input;
do
{
    Console.WriteLine("enter a num:");
    input = Convert.ToInt32(Console.ReadLine());
} while (input <= 0);
int somme = input;
for (int i = input - 1; i > 0; i--)
{
    somme *= i;
}
Console.WriteLine($"La factorielle de {input} vaut: {somme}");
*/
// 39. Afficher les nombres pairs de 2 à 200 si ils sont divisible par 3 avec une boucle `while`.
/*
int i = 2;
while (i <= 200)
{
    if (i % 3 == 0) Console.WriteLine(i);
    i += 2;
}
*/

// 40. Créer un tableau d'une certaine longueur, demander à l'utilisateur des nombres et les affecter au tableau tant qu'il n'est pas rempli entièrement.
/*
int[] table = new int[10];
for (int i = 0; i < table.Length; i++)
{
    int input;
    Console.WriteLine("saisir un nombre: ");
    input = Convert.ToInt32(Console.ReadLine());
    table[i] = input;
}
foreach (int element in table)
{
    Console.WriteLine(element);
}
*/

// 5. Utilisation des boucles avec `break` et `continue`

// 41. Utiliser une boucle pour afficher les nombres de 1 à 20, mais arrêter dès que vous atteignez 10.
/*
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
    if (i == 10) break;
}
*/
// 42. Créer une boucle qui demande un nombre et s'arrête si le nombre est 0.
/*
int input;
do
{
    Console.WriteLine("enter a number:");
    input = Convert.ToInt32(Console.ReadLine());
} while (input != 0);
*/
// 43. Utiliser `continue` pour afficher uniquement les nombres impairs de 1 à 10.
/*
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0) continue;
    Console.WriteLine(i);
}
*/
// 44. Écrire une boucle qui affiche les nombres de 1 à 20, mais saute les multiples de 3.
/*
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0) continue;
    Console.WriteLine(i);
}
*/
// 45. Demander à l'utilisateur un nombre et afficher tous les nombres de 1 à ce nombre, sauf ceux divisibles par 4.
/*
Console.WriteLine("enter a number: ");
int input = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= input; i++)
{
    if (i % 4 == 0) continue;
    Console.WriteLine(i);
}
*/
// 46. Créer une boucle qui affiche les éléments d'un tableau mais s'arrête dès qu'elle rencontre un élément spécifique.
/*
for (int i = 0; i < tableau.Length; i++)
{
    Console.WriteLine(tableau[i]);
    if (tableau[i] == 2025) break;
}
*/
// 47. Utiliser `break` pour quitter une boucle infinie après 5 itérations.
/*
int i = 0;
while (true)
{
    Console.WriteLine(i);
    if (i == 4) break;
    i++;
}
*/
// 48. Utiliser `continue` pour ignorer les lettres 'a' et 'e' lors de l'affichage des lettres d'un mot.
/*
const string mot = "banjouerno";
foreach(char l in mot)
{
    if (l == 'a' || l == 'e') continue;
    Console.WriteLine(l);
}
*/
// 49. Écrire une boucle qui demande à l'utilisateur de saisir un mot, mais qui s'arrête dès qu'il entre "stop".
/*
string input;
do
{
    Console.WriteLine("enter a word: ");
    input = Console.ReadLine();
} while (input != "stop");
*/
// 50. Afficher les éléments d’une liste, arrêter la boucle si un même élément apparaît une deuxième fois.
/**
 * PAS TERMINE
/*
List<int[]> list = new List<int[]>();
list = { 1,2,3,4,5,4,6,7,8,9,10};
List<int> testList = list;
*/

using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335; // Nécessaire pour Max, Min, Average

//EXO 5
/*
Console.WriteLine("--- Gestion des notes ---\n");
Console.WriteLine("Veuillez saisir cinq notes: ");
const int nbNotes = 5;
int[] notes = new int[nbNotes];

for (int i = 0; i < nbNotes; i++)
{
    do
    {
        Console.Write($"\t- Merci de saisir la note {i+1} (sur /20) : ");
        notes[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    } while (notes[i] < 0 || notes[i] > 20);
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleure note est de {notes.Max()}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est de {notes.Min()}");
Console.ResetColor();
Console.WriteLine($"La moyenne est de {notes.Average()}");
*/

// Autre avec List
/*
Console.WriteLine("--- Gestion des notes ---\n");
Console.WriteLine("Veuillez saisir cinq notes: ");
List<int> notes = new List<int>();
do
{
    Console.Write($"- Merci de saisir la note {notes.Count + 1} (sur /20) : ");
    notes.Add(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine();
} while ((notes[notes.Count] < 0 || notes[notes.Count] > 20) || notes.Count < 5);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleure note est de {notes.Max()}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est de {notes.Min()}");
Console.ResetColor();
Console.WriteLine($"La moyenne est de {notes.Average()}");
*/

// EXO 7 - Nombre Mystère
/*
Console.WriteLine("--- Trouver le nombre mystère ---\n");

// -- variables globales --
// ------------------------

Random random = new Random(); // seed (?)
int nombreMystere = random.Next(1, 51); // Nombre mystère entre 1 et 51
int compteur = 0; // compteur pour le nombre de coups

// boucle infinie
while (true)
{
    // Nouvelle itération == Nouveau coup -> On incrémente le compteur
    compteur++;
    // Demander à l'user de saisir un nombre
    Console.Write("\t Veuillez saisir un nombre: ");
    int input = Convert.ToInt32(Console.ReadLine());
    // Si le nombre est trop petit ou trop grand
    if (input != nombreMystere)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(input < nombreMystere ? "\t\tLe nombre mystère est plus grand." : "\t\tLe nombre mystère est plus petit."); // Affiche l'erreur appropriée
        Console.ResetColor();
        // Relancer la boucle
        continue;
    }
    // Si le nombre est trouvé, féliciter l'utilisateur et afficher le compteur
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nBravo !!!! Vous avez trouvé le nombre mystère!\n\nVous avez trouvé en {compteur} coups.\n");
    Console.ResetColor();
    // Demander à l'utilisateur de fermer le programme
    Console.WriteLine("Appuyez sur la touche Entrée pour fermer le programme...");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter); // Il ne se passe rien tant que l'utilisateur n'appuie pas sur "Entrée"
    break;
}
*/

//EXO 8
//Console.WriteLine("--- Quelle taille dois-je prendre ? ---");

///**
// * Retourne la Taille du vêtement recommandée en fonction de la taille (en cm) et du poids (en kg) fournis* 
// * - La fonction prend deux paramètres :
// *   - `t` : taille de la personne (en cm)
// *   - `p` : poids de la personne (en kg)
// * 
// * - Les tailles retournées vont de 1 à 3, ou 0 si aucune taille ne correspond aux critères.
// * 
// * Exemples :
// *   - `obtenirTaille(170, 50)` retourne `1`
// *   - `obtenirTaille(180, 65)` retourne `3`
// * 
// * @param t Taille de la personne (en cm)
// * @param p Poids de la personne (en kg)
// * @return La taille recommandée (1, 2, 3) ou 0 si aucune taille n'est trouvée.
// */
//static int obtenirTaille(int t, int p)
//{
//    // Définir des plages de valeurs définies pour chaque taille
//    /* --- Taille 1 --- */
//    if (p >= 43 && p < 48 && t >= 145 && t < 172) return 1; // ligne 1
//    if (p >= 48 && p < 54 && t >= 145 && t < 169) return 1; // ligne 2
//    if (p >= 54 && p < 60 && t >= 145 && t < 166) return 1; // ligne 3
//    if (p >= 60 && p < 66 && t >= 145 && t < 163) return 1; // ligne 4
//    /* --- Taille 2 ---  */
//    if (p >= 48 && p < 54 && t >= 169 && t < 183) return 2; // ligne 2
//    if (p >= 54 && p < 60 && t >= 166 && t < 178) return 2; // ligne 3
//    if (p >= 60 && p < 66 && t >= 163 && t < 175) return 2; // ligne 4
//    if (p >= 66 && p < 72 && t >= 160 && t < 172) return 2; // ligne 5
//    /* --- Taille 3 ---  */
//    if (p >= 54 && p < 60 && t >= 178 && t < 184) return 3; // ligne 3
//    if (p >= 60 && p < 66 && t >= 175 && t < 184) return 3; // ligne 4
//    if (p >= 66 && p < 72 && t >= 172 && t < 184) return 3; // ligne 5
//    if (p >= 72 && p < 78 && t >= 163 && t < 184) return 3; // ligne 6

//    return 0; // aucune des conditions n'est respectée, la taille n'existe pas
//}

//static int obtenirTailleOpti(int t, int p)
//{
//    // Définir les intervalles de poids et de taille pour chaque taille
//    int[,] tailles = new int[,] {
//        {1, 43, 48, 145, 172}, {1, 48, 54, 145, 169}, {1, 54, 60, 145, 166}, {1, 60, 66, 145, 163}, // Taille 1
//        {2, 48, 54, 169, 183}, {2, 54, 60, 166, 178}, {2, 60, 66, 163, 175}, {2, 66, 72, 160, 172}, // Taille 2
//        {3, 54, 60, 178, 184}, {3, 60, 66, 175, 184}, {3, 66, 72, 172, 184}, {3, 72, 78, 163, 184}  // Taille 3
//    };

//    // Parcourir les intervalles pour chaque taille
//    for (int i = 0; i < tailles.GetLength(0); i++)
//    {
//        int poidsMin = tailles[i, 1],
//            poidsMax = tailles[i, 2],
//            tailleMin = tailles[i, 3],
//            tailleMax = tailles[i, 4];
//        if (p >= poidsMin && p < poidsMax && t >= tailleMin && t < tailleMax)
//        {
//            return tailles[i, 0]; // Retourne la taille correspondante
//        }
//    }

//    return 0; // Aucun intervalle n'est respecté
//}

//// Demander à l'utilisateur d'entrer sa taille en cm
//Console.Write("\nEntrez votre taille (en cm) : ");
//int taille = Convert.ToInt32(Console.ReadLine());
//// Puis, son poids en kg
//Console.Write("\n\nEntrez votre poids (en kg) : ");
//int poids = Convert.ToInt32(Console.ReadLine());
//int numTaille = obtenirTaille(taille, poids);

//Console.WriteLine(numTaille != 0 ? $"Prenez la taille {numTaille}" : "Aucune taille ne vous correspond.");

// EXO 9 - Gestion des notes PARTIE 2

// -- Variables Globales --
// ------------------------
//List<int> notes = new List<int>(); // tableau dyna de notes de longueur 0 à l'initialisation
//int input;

//// Boucle infini
//while(true)
//{
//    afficherMenu();
//    // Demander une entrée utilisateur
//    input = Convert.ToInt32(Console.ReadLine());
//    Console.Clear();
//    if (input < 0 || input > 4) continue; // Si entrée invalide, recommencer
//    if (input == 0) Environment.Exit(0);
//    if (input == 1) saisirNotes();
//    // Si le tableau ne comporte pas encore de notes, interdire l'accès à ces options
//    if (notes.Count == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Aucune note n'a encore été entrée!");
//        continue;
//    }
//    if (input == 2) afficherNoteMax();
//    if (input == 3) afficherNoteMin();
//    if (input == 4) afficherNoteMoy();
//}

//void saisirNotes()
//{
//    // Colorer en vert
//    Console.ForegroundColor = ConsoleColor.Green;
//    // Afficher texte de saisie
//    Console.WriteLine("------ Saisir les notes ------\n" +
//        "(999 pour stopper la saisie\n");
//    // Réinitialiser les couleurs
//    Console.ResetColor();
//    // Boucle infinie
//    while (true)
//    {
//        // Demander à l'utilisateur de saisir la note "notes.Length + 1"
//        Console.Write($"Merci de saisir la note {notes.Count + 1} (sur /20) : ");
//        bool estEntier = int.TryParse(Console.ReadLine(), out int note);

//        // Si la note est de 999, break la boucle
//        if (note == 999) {
//            // On clear la console pour pouvoir réafficher le menu principal
//            Console.Clear();
//            break;
//        }
//        // Si la note n'est pas comprise entre 0 et 20 ou que l'utilisateur a fait une erreur de saisie
//        if (!estEntier || note < 0 || note > 20)
//        {
//            // Afficher l'erreur
//            Console.ForegroundColor= ConsoleColor.Red;
//            Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
//            Console.ResetColor();
//            // Relancer une itération
//            continue;
//        }

//        // Sinon, cela veut dire que l'on a entré une bonne note
//        notes.Add(note); // Ajouter cette note à la liste
//    }
//}

//static void afficherMenu()
//{
//    Console.ResetColor();
//    Console.Write("--- Gestion des notes avec menu ---\n" +
//        "1---Saisir les notes\n" +
//        "2---La plus grande note\n" +
//        "3---La plus petite note\n" +
//        "4---La moyenne des notes\n" +
//        "0---Quitter\n" +
//        "\n" +
//        "Faites votre choix: ");
//}

//void afficherNoteMax()
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("------ La plus grande note ------\n" +
//        "\n" +
//        $"La note la plus grande est: {notes.Max()}/20\n");
//}

//void afficherNoteMin()
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("------ La plus petite note ------\n" +
//        "\n" +
//        $"La note la plus petite est : {notes.Min()}/20\n");
//}

//void afficherNoteMoy()
//{
//    Console.ForegroundColor = ConsoleColor.Blue;
//    Console.WriteLine("------ La moyenne des notes ------\n" +
//        "\n" +
//        $"La note moyenne est de : {Math.Round(notes.Average(), 2)}/20\n");
//}

// ---------------------------
// -- Les Collections en C# --
// ---------------------------

// -- Exercice 1 --
// ----------------
/*
int[] notes = { 10, 12, 15, 8 };
int sum = 0;
if (notes.Length == 0) // si tableau vide, on arrête le programme
{
    Console.WriteLine("Tableau vide, pas de calculs possible.");
    return;
}
;
foreach(int note in notes)
{
    sum += note;
}
Console.WriteLine($"La moyenne vaut : {sum / notes.Length}");
*/

// -- Exercice 2 --
// ----------------
/*
int[] notes = { 10, 12, 15, 8 };
Console.WriteLine($"Min: {notes.Min()}\n" +
                    $"Max: {notes.Max()}\n" +
                    $"Moy: {notes.Average()}");
*/

/*
Console.Write("Veuillez entrer le nombre de prénoms:");
int n = Convert.ToInt32(Console.ReadLine());

List<string> prenoms = new List<string>();
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Entrer le prénom n°{i+1}: ");
    string prenom = Console.ReadLine();
    prenoms.Add(prenom);
}
prenoms.Sort();
Console.WriteLine("Voici les prénoms triés par ordre alphabetique: " + 
String.Join(",",prenoms));
//foreach (string p in prenoms)
//    Console.WriteLine(Char.ToUpper(p[0]) + p[1..p.Length]);

Console.Write("Quel prénom souhaitez-vous vérifier ?");
string? verif = Console.ReadLine();
if (prenoms.Contains(verif)) Console.WriteLine("Il existe!"); else Console.WriteLine("Il n'existe pas!"); ;
prenoms.RemoveAll(p => p.Length < 4);

Console.WriteLine("Voici les prénoms après avoir supprimé les prénoms à moins de 4 lettres: ");
foreach (string p in prenoms)
    Console.WriteLine(Char.ToUpper(p[0]) + p[1..p.Length]);
*/

// -- Exercice 4 --
// ----------------
/*
var capitals = new Dictionary<string, string>();
while (true)
{
    afficherMenu();
    //Saisie utilisateur
    Console.Write("\n Veuillez saisir une commande: ");
    int input = Convert.ToInt32(Console.ReadLine());

    if (input == 0) Environment.Exit(0);
    Console.Clear();
    if (input == 1) afficherInsertion();
    if (input == 2) afficherRecherche();
    Console.Clear();
}

void afficherMenu()
{
    Console.WriteLine("--- Pays et Capitales ---\n" +
        "\n" +
        "\t (1) - Insérez un pays et une capitale\n" +
        "\t (2) - Rechercher une capitale\n" +
        "\n" +
        "\t (0) - Quitter le programme\n" +
        "\n" +
        $"Le nombre total de couple pays/capitale est de : {capitals.Count}"
        );

}

void afficherInsertion()
{
    while (true)
    {
        Console.Write("Entrez un pays et sa capitale ([pays] [capitale]) ('stop' si vous souhaitez arrêter) ");
        string? input = Console.ReadLine();
        if (input == "stop") break;

        string[] kvInput = input.Split(" ");
        if (kvInput.Length != 2 || kvInput[0] == "" || kvInput[1] == "")
        {
            Console.WriteLine("Erreur lors de l'écriture, veuillez recommencer SVP.");
            continue;
        }
        capitals.Add(kvInput[0], kvInput[1]);
    }
}

void afficherRecherche()
{
    // Rechercher une capitale à partir d'un pays
    while (true)
    {
        Console.Write("Rechercher une capitale à partir d'un pays ('stop' pour revenir au menu principal): ");
        string input = Console.ReadLine();
        if (input == "stop") break;
        if (capitals.ContainsKey(input))
            Console.WriteLine($"La capitale de {input} est {capitals[input]}");
        else
            Console.WriteLine("Cette capitale n'a aucun pays d'associé.");
    }
}
*/

// -- Exercice 5 --
// ----------------
/*
int[] notes = { 12, 15, 20, 8, 9 };
List<string> prenoms = new List<string> { "Alice", "Bob", "Charlie" };
var capitales = new Dictionary<string, string>
{
    ["France"] = "Paris",
    ["Espagne"] = "Madrid",
    ["Italie"] = "Rome",
};

int index = 0;
foreach (int note in notes)
{
    Console.Write(note + " ");
    index++;
}
Console.WriteLine($"\nnombre d'éléments parcourus: {index}\n\n");

index = 0;
foreach (string prenom in prenoms)
    Console.Write($"{++index}: {prenom}, ");
Console.WriteLine($"\nnombre d'éléments parcourus: {index}\n\n");

index = 0;
foreach ((string pays, string capitale) in capitales)
{
    Console.Write($"{pays} : {capitale}\n");
    index++;
}
Console.WriteLine($"nombre d'éléments parcourus: {index}");
*/

// -------------------
// -- LES FONCTIONS --
// -------------------

// -- Exercice 1
// -------------
void afficherSeparateur()
{
    string tirets = "";
    for (int i = 0; i < 30; i++)
        tirets += '-';
    Console.WriteLine( tirets );
}

void print(string message, bool endLine = true)
{
    if (endLine)
        Console.WriteLine(message);
    else
        Console.Write(message);
}

//afficherSeparateur();
//print(message: "coucou") ;
//afficherSeparateur();
//print("toto");
//afficherSeparateur();


// -- Exercice 2
// -------------

int Additionner(int a, int b)
{
    return a + b;
}

List<int> numbers = new List<int>();
while (true)
{
    print("Veuillez entrer un nombre (0 pour arrêter) : ");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 0) break;
    numbers.Add(input);
}

List<string> chaines = numbers.Select(n => n.ToString()).ToList();

print($"La somme de {String.Join('+', chaines)} est de : {numbers.Sum()}");



//KATAS
/*
int[] list = { 1, 2, 3, 4 };
int step = 2;
List<int[]> newList = new List<int[]>();
for (int i = 0; i < list.Length-step; i++)
{
    int[] temp = new int[step];
    for (int j = 0; j < step; j++) temp[j] = list[i + j];
    newList.Add(temp);
}


for (int i = 0; i < newList.Count; i++)
{
    Console.WriteLine(string.Join(", ", newList[i]));
}
*/