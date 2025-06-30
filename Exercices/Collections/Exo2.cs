using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Collections
{
    internal class Exo2
    {
        // -- Exercice 2 --
        // ----------------
        /*
        int[] notes = { 10, 12, 15, 8 };
        Console.WriteLine($"Min: {notes.Min()}\n" +
                            $"Max: {notes.Max()}\n" +
                            $"Moy: {notes.Average()}");
        */

        /*
        Console.Write("Veuillez entrer le nombre de prénoms:");
        int n = Convert.ToInt32(Console.ReadLine());

        List<string> prenoms = new List<string>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Entrer le prénom n°{i+1}: ");
            string prenom = Console.ReadLine();
            prenoms.Add(prenom);
        }
        prenoms.Sort();
        Console.WriteLine("Voici les prénoms triés par ordre alphabetique: " + 
        String.Join(",",prenoms));
        //foreach (string p in prenoms)
        //    Console.WriteLine(Char.ToUpper(p[0]) + p[1..p.Length]);

        Console.Write("Quel prénom souhaitez-vous vérifier ?");
        string? verif = Console.ReadLine();
        if (prenoms.Contains(verif)) Console.WriteLine("Il existe!"); else Console.WriteLine("Il n'existe pas!"); ;
        prenoms.RemoveAll(p => p.Length < 4);

        Console.WriteLine("Voici les prénoms après avoir supprimé les prénoms à moins de 4 lettres: ");
        foreach (string p in prenoms)
            Console.WriteLine(Char.ToUpper(p[0]) + p[1..p.Length]);
        */

    }
}
