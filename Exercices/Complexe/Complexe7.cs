using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DOTNET_DAY2.Exercices.Complexe
{
    internal class Complexe7
    {
        /*
        string textePalindrome = @"
            Ce midi, Anna part se promener. ""Ésope reste ici et se repose"", murmure-t-elle en passant devant le vieux théâtre. Un radar clignote près du kayak échoué. ""Élu par cette crapule"", rigole-t-elle, lisant un graffiti.

            Soudain, elle tombe sur un panneau : ""La mari ira mal"". Intriguée, elle note aussi ""Noël à Léon"" sur un calendrier. Le vent souffle, son écharpe vole. ""À l'étape, épate-la !"" pense-t-elle, amusée.

            Rentrée chez elle, elle s’exclame : ""Étonnant, à Nantes, on note !"" avant de boire son thé.";
        Console.WriteLine(string.Join(" / ", Complexe7.TrouverPalindromes(textePalindrome)));
        */
        /* ---------------------------------------- */
        /* -- DETECTEUR DE PALINDROMES EMBARQUES -- */
        /* ---------------------------------------- */
        public static List<string> TrouverPalindromes(string texte)
        {
            List<string> listeDePalindrome = new List<string>();
            List<string> motsPropres = new List<string>();
            const string specialChars = "'(),:;.@\"!\t\n";

            // Construire un mot propre caractère par caractère
            StringBuilder motCourant = new StringBuilder();

            foreach (char c in texte)
            {
                if (specialChars.Contains(c) || char.IsWhiteSpace(c))
                {
                    // Quand on rencontre un séparateur, ajouter le mot en cours s'il existe
                    if (motCourant.Length > 0)
                    {
                        motsPropres.Add(motCourant.ToString());
                        motCourant.Clear(); // réinitialiser motCourant pour stocker un nouveau mot
                    }
                }
                else
                {
                    // Ajouter le caractère en minuscule à motCourant
                    motCourant.Append(char.ToLower(c));
                }
            }

            // Ajouter le dernier mot s'il existe
            if (motCourant.Length > 0)
            {
                motsPropres.Add(motCourant.ToString());
            }
            // 2.Pour chaque position `i`, et pour chaque longueur `l ≥ 3` possible, prends la sous-chaîne `texte.Substring(i, l)` et teste si elle est égale à son inverse(`Reverse`).
            for (int i = 0; i < motsPropres.Count; i++)
            {
                if (motsPropres[i].Length >= 3)
                {
                    // On a un mot, et on teste si son inverse est la même
                    string motPropreInverse = new string(motsPropres[i].Reverse().ToArray());
                    if (motsPropres[i] == motPropreInverse && !listeDePalindrome.Contains(motPropreInverse))
                        listeDePalindrome.Add(motsPropres[i]); // 3.Stocke les résultats uniques dans une liste.
                }
            }
            return listeDePalindrome;
        }
    }
}
