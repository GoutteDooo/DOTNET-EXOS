using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Complexe
{
    internal class Complexe6
    {
        /* -- EXO COMPLEXE 6 -- */
        /* -- GENERATEUR MDP -- */
        /* -------------------- */
        
        public static string GenererMotDePasse(int longueur)
        {
            string[] portions = new string[3] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "abcdefghijklmnopqrstuvwxyz", "&é'(-è_çà)=;.,:!ùµ^$%*\"" };
            // Si la longueur est inférieure à huit, renvoyer une erreur
            if (longueur < 8) throw new Exception("Longueur inférieure à huit caractères -- Génération de mot de passe impossible");
            // Sinon, stocker longueur / 3 dans une variable portionLongueur
            int portionLongueur = (int)Math.Ceiling(longueur / 3.0);
            // Récupérer 3 portion : une de maj, une de min et une de special
            // Pour chaque portion p 
            string motDePasse = "";
            foreach(string portion in portions)
            {
                for (int i = 0; i < portionLongueur; i++)
                {
                    // Récupérer une lettre random de l'index 0 à la longueur - 1 de la portion p 
                    Random rng = new Random();
                    int index = rng.Next(portion.Length);
                    // Si la lettre prise est déjà présente dans le MDP, relancer le rng
                    while (motDePasse.Contains(portion[index]))
                    {
                        index = rng.Next(portion.Length);
                    }
                    motDePasse += portion[index]; // Concaténer ces 3 portion en une seule string motDePasse
                    // Répéter cela portionLongueur fois
                    Console.WriteLine($"MDP = {motDePasse}\n" +
                        $"portion: {portion}");
                }
            }
            // randomizer motDePasse
            string MelangerMDP(string mdp)
            {
                Random random = new Random();
                return new string(mdp.OrderBy(c => random.Next()).ToArray());
            }
            motDePasse = MelangerMDP(motDePasse);
            // retourner motDePasse entre 0 et longueur caractères (dans les cas où longueur % portion a des restes)
            return motDePasse[0..longueur];
        }
        
    }
}
