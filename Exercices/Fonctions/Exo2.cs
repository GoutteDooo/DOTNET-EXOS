using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Fonctions
{
    internal class Exo2
    {
        // -- Exercice 2
        // -------------
        /*
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
        */
        /*
        int num = 2;
        bool estPair(int a)
        {
            return a % 2 == 0;
        }

        Console.Write($"{num} est {(estPair(num) ? "pair" : "impair")}");
        */
        /*
        double CalculerPrixTTC(double prixHT, double tauxTVA = 0.20)
        {
            return prixHT + (prixHT * tauxTVA);
        }

        Console.WriteLine($"{CalculerPrixTTC(12.5)}");
        */

        //Console.WriteLine(Multiplier(3, 2));
        //Console.WriteLine(Multiplier(2, 3, 4));
        //Console.WriteLine(Multiplier([2,3,4,5]));

    }
}
