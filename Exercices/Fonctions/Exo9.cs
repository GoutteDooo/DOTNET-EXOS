using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Fonctions
{
    internal class Exo9
    {
        // -- Exercice 9
        // -------------
        /*
        Console.Write("Veuillez écrire un nombre de notes à entrer: ");
        int nbNotes = getInt();
        int[] notes = new int[nbNotes];
        for(int i = 0; i < nbNotes; i++)
        {
            Console.Write($"Entrez la note {i+1}: ");
            int note = getInt();
            notes[i] = note;
        }
        Console.WriteLine($"La moyenne est {NotesUtils.CalculerMoyenne(notes)}");
        */
        //NotesUtils listeDeNotes = new NotesUtils();
        //listeDeNotes.AfficherStats();
    }

    internal class NotesUtils
    {
        List<int> notes = new List<int> { 15, 11, 18 };
        public static double CalculerMoyenne(int totalPoints, int nombreNotes)
        {
            return Math.Round((double)totalPoints / nombreNotes, 2);
        }

        /**
         * Méthode statique car pas besoin d'accéder aux valeurs d'une instance
         * L'utilisateur peut y insérer n'importe quel tableau de notes en paramètres
         * et aura en retour la moyenne, ainsi que d'autres trucs bonus
        */
        public static double CalculerMoyenne(int[] notes)
        {
            Action<int> AfficherNoteMax = notesMax => Console.WriteLine($"La note maximale est {notesMax}");
            AfficherNoteMax(notes.Max());

            Action<int[]> Trier = n =>
            {
                Array.Sort(n);
                Array.Reverse(n);
            };

            Trier(notes);
            Console.WriteLine($"notes: {string.Join(" ,", notes)}");

            return Math.Round((double)notes.Average(), 2);
        }

        public void AfficherStats()
        {
            while (true)
            {
                Console.WriteLine("Quelle statistique souhaitez-vous afficher ?\n" +
                    "\n" +
                    "\t1 - Note minimale\n" +
                    "\t2 - Note maximal\n" +
                    "\t3 - Note moyenne\n" +
                    "\n" +
                    "\t0 - Quitter\n");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0) break;
                Console.Clear();
                if (input == 1)
                    Console.WriteLine($"La note minimale est de {notes.Min()}");
                if (input == 2)
                    Console.WriteLine($"La note moyenne est de {notes.Max()}");
                if (input == 3)
                    Console.WriteLine($"La note moyenne est de {CalculerMoyenne(notes.ToArray())}");

            }
        }
    }
}
