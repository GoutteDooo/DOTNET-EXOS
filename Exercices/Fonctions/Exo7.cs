using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Fonctions
{
    internal class Exo7
    {
        static int Multiplier(int a, int b)
        {
            return a * b;
        }

        static int Multiplier(int c, int d, int e)
        {
            return c * d * e;
        }

        static int Multiplier(int[] mul)
        {
            return mul.Aggregate(1, (acc, x) => acc * x);
        }

        static void AfficherSeparateur()
        {
            Console.WriteLine(new string('-', 30));
        }
        static int getInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static string? getString()
        {
            return Console.ReadLine();
        }

        static void BonjourGlobal()
        {
            Console.WriteLine("Bonjour les gens");
        }

        public void BonjourPersonnalise(string nom)
        {
            Console.WriteLine($"Bonjour {nom}");
        }

        // -- Exercice 7
        // -------------
        /*
        Func<int, int> Triple = x => x * 3;
        Console.WriteLine(Triple(3));

        Action<string> Annoncer = str => Console.WriteLine($"Annonce: {str}");
        Annoncer("Fin de l'exercice 7");

        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
        ints.RemoveAll(x => x % 2 != 0);
        Console.WriteLine(string.Join(" ,", ints));
        */
        // -- Exercice 8
        // -------------
        /*
        // Exemple fictif
        void Traiter(int a, int b, int c)
        {
            // calcule la somme des paramètres
            int[] somme = new int[] { a, b, c };
            Console.WriteLine(somme.Sum());

            // S'ils sont tous positifs
            Func<int, bool> EstPositif = n => n > 0;
            if (EstPositif(a) && EstPositif(b) && EstPositif(c))
                Console.WriteLine("Tous positifs");

            // calculer la moyenne
            Func<int[], int> calculerMoyenne = t => t.Sum() / t.Length;
            Console.WriteLine($"Moyenne = {calculerMoyenne(somme)}");
        }
        */
    }
}
