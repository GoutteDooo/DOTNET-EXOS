using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Complexe
{
    internal class Complexe3
    {
        // -- EXOS COMPLEXES 3 --
        // --      SUDOKU      --
        // ----------------------

        //        int[,] grille = new int[9, 9];
        //        /**
        //         * Retourne true si :
        //         * - Chaque ligne possède les chiffres de 1 à 9
        //         * - Chaque colonne possède les chiffres de 1  à 9
        //         * - Chaque bloc de 3x3 possède les chiffres de 1 à 9
        //         */
        //        bool EstSudokuValide(int[,] grille)
        //        {
        //            /* -- CONDITIONS -- */
        //            // Est-ce une grille 9x9 
        //            if (!(grille.GetLength(0) == 9 && grille.GetLength(1) == 9))
        //                return false;
        //            int longueur = grille.GetLength(0);
        //            // CONDITION - Vérifier chaque ligne
        //            for (int i = 0; i < longueur; i++)
        //            {
        //                // créer un tableau temporaire
        //                int[] ligne = new int[longueur];
        //                for (int j = 0; j < longueur; j++)
        //                {
        //                    // pour chaque item de la ligne actuelle
        //                    ligne[j] = grille[i, j];
        //                }
        //                // Trier la ligne
        //                Array.Sort(ligne);

        //                // Vérifier qu'il y'a les chiffres de 1 à 9
        //                for (int k = 0; k < longueur; k++)
        //                {
        //                    if (!(ligne[k] == k + 1))
        //                        return false;
        //                }
        //                // Les vérifications sont valides, passer à la ligne suivante...
        //            }
        //            // CONDITION - Vérifier chaque colonne
        //            for (int i = 0; i < longueur; i++)
        //            {
        //                // créer un tableau temporaire
        //                int[] colonne = new int[longueur];
        //                for (int j = 0; j < longueur; j++)
        //                {
        //                    // pour chaque item de la colonne actuelle
        //                    colonne[j] = grille[j, i];
        //                }
        //                // Trier la colonne actuelle
        //                Array.Sort(colonne);

        //                // Vérifier qu'il y'a les chiffres de 1 à 9 dans cette colonne
        //                for (int k = 0; k < longueur; k++)
        //                {
        //                    if (!(colonne[k] == k + 1))
        //                        return false;
        //                }
        //                // Les vérifications sont valides, passer à la colonne suivante...
        //            }

        //            int longueurBloc = 3;
        //            // - CONDITION - chaque bloc
        //            for (int i = 0; i < longueur; i += longueurBloc)
        //            {
        //                for (int j = 0; j < longueur; j += longueurBloc)
        //                {
        //                    // créer un tableau temporaire
        //                    List<int> bloc = new List<int>();

        //                    // Pour chaque bloc
        //                    for (int k = 0; k < longueurBloc; k++)
        //                    {
        //                        for (int l = 0; l < longueurBloc; l++)
        //                        {
        //                            // pour chaque item [k,l] du bloc de 3x3 actuel
        //                            bloc.Add(grille[i+k, j+l]);
        //                        }
        //                    }
        //                    // Trier la ligne
        //                    bloc.Sort();

        //                    // Vérifier qu'il y'a les chiffres de 1 à 9
        //                    for (int m = 0; m < longueur; m++)
        //                    {
        //                        if (!(bloc[m] == m + 1))
        //                            return false;
        //                    }
        //                }
        //            }
        //            return true;
        //        }

        //        // Grille valide
        //        int[,] validGrid = new int[,]
        //        {
        //{ 5, 3, 4, 6, 7, 8, 9, 1, 2 },
        //{ 6, 7, 2, 1, 9, 5, 3, 4, 8 },
        //{ 1, 9, 8, 3, 4, 2, 5, 6, 7 },
        //{ 8, 5, 9, 7, 6, 1, 4, 2, 3 },
        //{ 4, 2, 6, 8, 5, 3, 7, 9, 1 },
        //{ 7, 1, 3, 9, 2, 4, 8, 5, 6 },
        //{ 9, 6, 1, 5, 3, 7, 2, 8, 4 },
        //{ 2, 8, 7, 4, 1, 9, 6, 3, 5 },
        //{ 3, 4, 5, 2, 8, 6, 1, 7, 9 },
        //        };

        //        // Grille invalide (duplication dans la première ligne)
        //        int[,] invalidGrid = new int[,]
        //        {
        //{ 5, 3, 4, 6, 7, 8, 9, 1, 5 },  // 5 répété
        //{ 6, 7, 2, 1, 9, 5, 3, 4, 8 },
        //{ 1, 9, 8, 3, 4, 2, 5, 6, 7 },
        //{ 8, 5, 9, 7, 6, 1, 4, 2, 3 },
        //{ 4, 2, 6, 8, 5, 3, 7, 9, 1 },
        //{ 7, 1, 3, 9, 2, 4, 8, 5, 6 },
        //{ 9, 6, 1, 5, 3, 7, 2, 8, 4 },
        //{ 2, 8, 7, 4, 1, 9, 6, 3, 5 },
        //{ 3, 4, 5, 2, 8, 6, 1, 7, 9 },
        //        };

        //        // Autre grille invalide (duplication dans le bloc central)
        //        int[,] invalidGrid1 = new int[,]
        //        {
        //{ 1, 2, 3, 4, 5, 6, 7, 8, 9 },
        //{ 4, 5, 6, 7, 8, 9, 1, 2, 3 },
        //{ 7, 8, 9, 1, 2, 3, 4, 5, 6 },
        //{ 2, 3, 1, 5, 6, 4, 8, 9, 7 },
        //{ 5, 6, 4, 8, 5, 2, 9, 1, 3 },  // 5 répété dans le bloc central
        //{ 8, 9, 7, 2, 1, 3, 6, 4, 5 },
        //{ 3, 1, 2, 6, 4, 5, 9, 7, 8 },
        //{ 6, 4, 5, 9, 7, 8, 3, 6, 1 },  // 6
        //{ 9, 7, 8, 3, 9, 1, 2, 3, 4 },
        //        };

        //        Console.WriteLine($"La grille IG1 est {(EstSudokuValide(invalidGrid1) ? "valide" : "invalide")}");
        //        Console.WriteLine($"La grille IG est {(EstSudokuValide(invalidGrid) ? "valide" : "invalide")}");
        //        Console.WriteLine($"La grille VG est {(EstSudokuValide(validGrid) ? "valide" : "invalide")}");

    }
}
