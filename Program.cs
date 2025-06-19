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
if (num1 != num2)
{
    Console.WriteLine("They are different.");
}
else
{
    Console.WriteLine("They are equals");
};
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

Console.WriteLine("Enter a string: ");
string? input = Console.ReadLine();
if (input == null) return;
string output = input.Length > 5 ? input.Substring(0,5) : input;
Console.WriteLine($"Votre string est: {output}");
;