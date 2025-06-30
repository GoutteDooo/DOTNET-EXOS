using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Fonctions
{
    internal class Exo4
    {
        // -- Exercice 4
        // -------------
        /*
        int t = 5; //t est globale

        void FoncA()
        {
            int u = 10; //u est locale à FoncA et sera supprimée à la sortie
            Console.WriteLine(t);
            Console.WriteLine(u);
        }

        void FoncB()
        {
            Console.WriteLine(u); // u n'existe pas
            // u n'était présent que dans FoncA
            t = 7; // ici ça fonctionne
        }
        */
        // la solution est donc de peut-être déclarer u en globale
        // ou alors d'exécuter FoncB(u) avec u en paramètre dans FoncA() et de passer u comme argument

    }
}
