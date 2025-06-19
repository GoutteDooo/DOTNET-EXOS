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
for (int i = 0; i < 5; i++) Console.WriteLine((char)(i + 97));



