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
        /* ---------------------------------------- */
        /* -- DETECTEUR DE PALINDROMES EMBARQUES -- */
        /* ---------------------------------------- */
        public static List<string> TrouverPalindromes(string phrase)
        {
            List<string> listeDePalindrome = new List<string>();
            List<string> motsPropres = new List<string>();
            const string specialChars = "'(),:;.@\"!\t\n";

            // Construire un mot propre caractère par caractère
            StringBuilder motCourant = new StringBuilder();

            foreach (char c in phrase)
            {
                if (specialChars.Contains(c) || char.IsWhiteSpace(c))
                {
                    // Quand on rencontre un séparateur, ajouter le mot en cours s'il n'est pas vide
                    if (motCourant.Length > 0)
                    {
                        motsPropres.Add(motCourant.ToString());
                        motCourant.Clear();
                    }
                }
                else
                {
                    // Ajouter le caractère en minuscule
                    motCourant.Append(char.ToLower(c));
                }
            }

            // Ajouter le dernier mot s'il existe
            if (motCourant.Length > 0)
            {
                motsPropres.Add(motCourant.ToString());
            }
            // 2.Pour chaque position `i`, et pour chaque longueur `l ≥ 3` possible, prends la sous-chaîne `phrase.Substring(i, l)` et teste si elle est égale à son inverse(`Reverse`).
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
