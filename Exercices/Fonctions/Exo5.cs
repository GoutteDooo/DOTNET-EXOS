using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Fonctions
{
    internal class Exo5
    {
        // -- Exercice 5
        // -------------
        //Program.BonjourGlobal();
        //Program program = new Program();
        //program.BonjourPersonnalise("Alice");
        //**Questions de réflexion**

        //-Pourquoi la méthode statique fonctionne-t-elle sans création d’objet ?
        // Une méthode statique est créée dans ce but : elle peut être appelée de manière globale sans besoin d'instance.

        //-Pourquoi devez - vous créer une instance de la classe pour appeler la méthode non statique ?
        // C'est le but d'une méthode non statique. Elle est créée pour chaque instance de celle-ci.
        // Elle reçoit un paramètre "this", et peut modifier les propriétés de l'instance appelée.

        //-Que révèle l’utilisation du mot - clé `static` sur la façon dont C# gère les méthodes liées à la classe versus celles liées à un objet ?
        // Par déduction, je dirais que la fonction n'est pas dynamique. Elle peut être appelée n'importe quand, et n'a pas besoin d'instance pour cela.
        // Ne pas écrire "static" signifie que la fonction peut être dynamique, elle a besoin d'une instance pour être appelée, et peut avoir des comportements différents en fonction de l'instance dans laquelle elle a été appelée.
        /*
        void AnalyseNombres(int[] tableau)
        {
            bool estPair(int x)
            {
                return x % 2 == 0;
            }
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine($"{tableau[i]} est {(estPair(tableau[i]) ? "pair" : "impair")}");
            }
        }
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Entrez un nombre: ");
            int n = getInt();
            if (n == 0) break;
            numbers.Add(n);
        }
        AnalyseNombres(numbers.ToArray());
        */
        /*
        Func<int, int> carre = x => x * x;
        Console.WriteLine(carre(5));
        */
        /*
        int[] nombres = {2,3,4,5,6};
        var nombresCarres = nombres.Select(x => x * x);
        Console.WriteLine(string.Join(", ", nombresCarres));

        Action<string> Saluer = nom =>
        {
            Console.WriteLine("Bonjour les gens");
        };

        Saluer("Jean");
        */
    }
}
