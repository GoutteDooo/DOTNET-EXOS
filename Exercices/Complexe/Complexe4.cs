using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Complexe
{
    internal class Complexe4
    {
        /* -- EXOS COMPLEXES 4 -- */
        /* --    ANAGRAMMES    -- */
        /* ---------------------- */

        //List<List<string>> GrouperAnagrammes(List<string> mots)
        //{
        //    Dictionary<string, List<string>> anagrammes = new();
        //    // Pour chaque mots
        //    foreach (string mot in mots)
        //    {
        //        // Prendre le premier mot
        //        // Le trier
        //        char[] lettres = mot.ToCharArray();
        //        Array.Sort(lettres);
        //        string motTrié = new string(lettres);
        //        //Console.WriteLine($"mot ({mot}) trié -> {motTrié}");

        //        // Si la clé du mot trié existe dans le dictionnaire,
        //        if (anagrammes.ContainsKey(motTrié))
        //        {
        //            // Alors, si ce mot n'existe pas déjà dans la liste de cette clé,
        //            if (!anagrammes[motTrié].Contains(mot))
        //                anagrammes[motTrié].Add(mot); // L'ajouter à sa liste
        //            // Sinon, ne rien faire
        //        }
        //        else
        //        {
        //            // Sinon,
        //            // Ajouter la clé du mot trié dans le dictionnaire et y insérer le mot dans sa liste
        //            anagrammes[motTrié] = new List<string> { mot };
        //        }
        //    }
        //    // Le dictionnaire est rempli
        //    // Retourner les valeurs du dictionnaire sous forme de liste de liste
        //    List<List<string>> output = new List<List<string>>();
        //    foreach (var pair in anagrammes)
        //        output.Add(pair.Value);

        //    // test : afficher les listes de groupe
        //    Console.Write("Voici les listes d'anagrammes: \n[");
        //    foreach (var list in output)
        //        Console.WriteLine($"[{(string.Join(", ", list))}]");
        //    Console.WriteLine("]");
        //    return output;
        //}

        //var mots = new List<string>
        //{
        //    "écouter", "reculer", "troucer", "salir", "rails",
        //    "chien", "niche", "rame", "amer", "mera", "rame"
        //};

        //GrouperAnagrammes(mots);

    }
}
