using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Alex
{
    internal class Calculatrice
    {
        List<string> calculs = new();
        bool numState = true;
        /**
         * Se charge d'afficher les calculs effectués par l'utilisateur
         * Lorsque l'utilisateur appuie sur "entrée", le résultat est affiché
         */
        public void DisplayCalc()
        {
            // L'utilisateur doit commencer par entrer un nombre, sinon une erreur sera affichée
            while (true)
            {
                // Afficher la ligne de calcul
                foreach (string s in calculs)
                {
                    Console.Write($"{s} ");
                }
                string? input = Console.ReadLine();
                input = input.Trim(); // Retire les espaces inutiles
                /* ERROR CHECKING */
                // Si entrée doit être un nombre
                if (numState)
                {
                    if (!float.TryParse(input, out float nombre))
                    {
                        Console.Clear();
                        Console.WriteLine("ERREUR");
                        continue;
                    }
                    calculs.Add(input.ToString());
                }
                else // Si entrée doit être un opérateur
                {   
                    if (input.Length != 1 || !"+-/*^=".Contains(input))
                    {
                        Console.Clear();
                        Console.WriteLine("ERREUR");
                        continue;
                    }
                    calculs.Add(input.ToString());
                    if (input == "=")
                    {
                        double resultat = Calculer(calculs);
                        calculs.Clear();
                        calculs.Add(Convert.ToString(resultat));
                        continue;
                    }
                }
                numState = !numState;
                Console.Clear();
            }

            // A chaque fois que l'utilisateur a entré un nombre, il doit entrer un opérateur, sinon une erreur est affichée, l'invitant à une nouvelle entrée
            // Lorsque l'utilisateur appuie sur "entrée", tout les éléments de la liste sont calculés dans une fonction "Calculer"
            // Tous les éléments de la liste sont ensuite supprimé
            // Et insère "resultat" dans la liste
            // La liste est affichée en permanence sous forme de string dans le format suivant :
            // n_o_n_o_n_... (n pour nombre, o pour opérateur, _ pour espace)
            // Et l'entrée utilisateur est toujours située un espace après

            /**
             * Retourne le résultat d'une liste de calculs sous le format suivant :
             * [num,op,num,op,num...,num]
             */
            double Calculer(List<string> calculs)
            {
                // Puissances prioritaires
                AppliquerOperation(calculs, "^", (a, b) => Math.Pow(a, b));
                // Racines carrées
                
                // Vérifie s'il y a des '*' et les calcules
                AppliquerOperation(calculs, "*", (a, b) => a * b);
                // Vérifie s'il y'a des '/' et les calcules
                AppliquerOperation(calculs, "/", (a, b) => a / b);
                // Vérifie s'il y'a des '+' et les calcules
                AppliquerOperation(calculs, "+", (a, b) => a + b);
                // Vérifie s'il y'a des '-' et les calcules
                AppliquerOperation(calculs, "-", (a, b) => a - b);

                return Convert.ToDouble(calculs[0]);
            }
        
            void AppliquerOperation(List<string> calculs, string operateur, Func<double, double, double> operation)
            {
                // Parcourir la liste et 
                for (int i = 0; i < calculs.Count; i++)
                {
                    // Tant qu'on est pas au bout
                    // S'il y'a l'opérateur en question qui apparaît,
                    if (calculs[i] == operateur)
                    {
                        // On calcule les deux nombres a gauche et a droite
                        // On les stocke dans une variable temp
                        double gauche = Convert.ToDouble(calculs[i - 1]);
                        double droite = Convert.ToDouble(calculs[i + 1]);
                        double resultat = operation(gauche, droite);
                        int iTemp = i - 1;
                        // On supprime les trois éléments de la liste
                        calculs.RemoveRange(iTemp, 3);
                        // Et on insère temp à l'index de '*' - 1 (iTemp)
                        calculs.Insert(iTemp, Convert.ToString(resultat));
                        i--;
                    }
                }
            }
        }
    }
}
