using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Collections
{
    internal class Exo3
    {
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

    }
}
