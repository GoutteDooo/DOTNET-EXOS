﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices1a100
{
    internal class Exercices1a100
    {

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



        // 51. Écrire un programme qui affiche la table de multiplication de 1 à 10 avec des boucles imbriquées.
        /*
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"--- Table de {i} ---");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i*j}");
            }
        }
        */

        // 52. Créer un programme qui affiche un rectangle de caractères "X" de taille donnée par l'utilisateur.
        /*
        Console.Write("Entrer un nombre: ");
        int input = Convert.ToInt32(Console.ReadLine());
        for (int i  = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Console.Write("X");
            }
            Console.WriteLine();
        }
        */

        // 53. Utiliser des boucles imbriquées pour afficher une pyramide de nombres.

        //Console.Write("Entrer un nombre: ");
        //int input = getInt();
        // la boucle devrait afficher comme cela :
        /**
         * ___________1
         * __________2_3
         * _________4_5_6
         * ________7_8_9_10
         * ______11_12_13_14_15
         * ____15_16_17_18_19_20
         * __20_21_23_24_25_26_27
         * 28_29_30_31_32_33_34_35
         */
        
        //// -- Exercice 76 --
        //// -----------------
        //// Déclarer une variable somme
        //// Prendre un nombre (ex 6)
        //for (int nombreTest = 1; nombreTest < 100000; nombreTest++)
        //{
        //    int somme = 0;
        //    for (int i = nombreTest - 1; i > 0; i--)
        //    {
        //        // Vérifier que ce nombre % diviseur croissant vaut zéro, sauf lui-même
        //        if (nombreTest % i == 0)
        //        {
        //            // Lorsque le calcul vaut zéro, l'ajouter à une variable somme
        //            somme += i;
        //            //Console.WriteLine($"somme= {somme}");
        //        }
        //    }
        //    if (nombreTest == somme)
        //        Console.WriteLine($"{nombreTest} parfait");
        //}
        //// Une fois que tout les calculs sont effectués, vérifier si nombre == somme
        //// Si oui, retourner true, sinon false
    }
}
