using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Alex
{
    internal class Exo8
    {
        //EXO 8
        //Console.WriteLine("--- Quelle taille dois-je prendre ? ---");

        ///**
        // * Retourne la Taille du vêtement recommandée en fonction de la taille (en cm) et du poids (en kg) fournis* 
        // * - La fonction prend deux paramètres :
        // *   - `t` : taille de la personne (en cm)
        // *   - `p` : poids de la personne (en kg)
        // * 
        // * - Les tailles retournées vont de 1 à 3, ou 0 si aucune taille ne correspond aux critères.
        // * 
        // * Exemples :
        // *   - `obtenirTaille(170, 50)` retourne `1`
        // *   - `obtenirTaille(180, 65)` retourne `3`
        // * 
        // * @param t Taille de la personne (en cm)
        // * @param p Poids de la personne (en kg)
        // * @return La taille recommandée (1, 2, 3) ou 0 si aucune taille n'est trouvée.
        // */
        //static int obtenirTaille(int t, int p)
        //{
        //    // Définir des plages de valeurs définies pour chaque taille
        //    /* --- Taille 1 --- */
        //    if (p >= 43 && p < 48 && t >= 145 && t < 172) return 1; // ligne 1
        //    if (p >= 48 && p < 54 && t >= 145 && t < 169) return 1; // ligne 2
        //    if (p >= 54 && p < 60 && t >= 145 && t < 166) return 1; // ligne 3
        //    if (p >= 60 && p < 66 && t >= 145 && t < 163) return 1; // ligne 4
        //    /* --- Taille 2 ---  */
        //    if (p >= 48 && p < 54 && t >= 169 && t < 183) return 2; // ligne 2
        //    if (p >= 54 && p < 60 && t >= 166 && t < 178) return 2; // ligne 3
        //    if (p >= 60 && p < 66 && t >= 163 && t < 175) return 2; // ligne 4
        //    if (p >= 66 && p < 72 && t >= 160 && t < 172) return 2; // ligne 5
        //    /* --- Taille 3 ---  */
        //    if (p >= 54 && p < 60 && t >= 178 && t < 184) return 3; // ligne 3
        //    if (p >= 60 && p < 66 && t >= 175 && t < 184) return 3; // ligne 4
        //    if (p >= 66 && p < 72 && t >= 172 && t < 184) return 3; // ligne 5
        //    if (p >= 72 && p < 78 && t >= 163 && t < 184) return 3; // ligne 6

        //    return 0; // aucune des conditions n'est respectée, la taille n'existe pas
        //}

        //static int obtenirTailleOpti(int t, int p)
        //{
        //    // Définir les intervalles de poids et de taille pour chaque taille
        //    int[,] tailles = new int[,] {
        //        {1, 43, 48, 145, 172}, {1, 48, 54, 145, 169}, {1, 54, 60, 145, 166}, {1, 60, 66, 145, 163}, // Taille 1
        //        {2, 48, 54, 169, 183}, {2, 54, 60, 166, 178}, {2, 60, 66, 163, 175}, {2, 66, 72, 160, 172}, // Taille 2
        //        {3, 54, 60, 178, 184}, {3, 60, 66, 175, 184}, {3, 66, 72, 172, 184}, {3, 72, 78, 163, 184}  // Taille 3
        //    };

        //    // Parcourir les intervalles pour chaque taille
        //    for (int i = 0; i < tailles.GetLength(0); i++)
        //    {
        //        int poidsMin = tailles[i, 1],
        //            poidsMax = tailles[i, 2],
        //            tailleMin = tailles[i, 3],
        //            tailleMax = tailles[i, 4];
        //        if (p >= poidsMin && p < poidsMax && t >= tailleMin && t < tailleMax)
        //        {
        //            return tailles[i, 0]; // Retourne la taille correspondante
        //        }
        //    }

        //    return 0; // Aucun intervalle n'est respecté
        //}

        //// Demander à l'utilisateur d'entrer sa taille en cm
        //Console.Write("\nEntrez votre taille (en cm) : ");
        //int taille = Convert.ToInt32(Console.ReadLine());
        //// Puis, son poids en kg
        //Console.Write("\n\nEntrez votre poids (en kg) : ");
        //int poids = Convert.ToInt32(Console.ReadLine());
        //int numTaille = obtenirTaille(taille, poids);

        //Console.WriteLine(numTaille != 0 ? $"Prenez la taille {numTaille}" : "Aucune taille ne vous correspond.");

    }
}
