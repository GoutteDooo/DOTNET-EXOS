using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Alex
{
    internal class Exo5
    {
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
    }
}
