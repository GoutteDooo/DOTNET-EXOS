using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DOTNET_DAY2.Exercices.Alex
{
    internal class Calculatrice
    {
        string[] caracteresValides = { "+","-","/","*","^","." };
        List<string> calculs = new();
        bool numState = true;
        /**
         * Calculatrice SIMPLE
         * Se charge d'afficher les calculs effectués par l'utilisateur
         * Lorsque l'utilisateur appuie sur "entrée", le résultat est affiché
         */
        public void DisplayCalc()
        {
            while (true)
            {
                // Afficher la ligne de calcul
                foreach (string s in calculs)
                {
                    Console.Write($"{s} ");
                }
                // L'utilisateur doit commencer par entrer un nombre, sinon une erreur sera affichée
                string? input = Console.ReadLine();
                input = input.Trim(); // Retire les espaces inutiles

                ConvertirCalculs(input);
                return;
                

                // Sinon
                calculs.Add(input.ToString());
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
        
            /**
             * Applique l'opération de la fonction "operation" passée en paramètre
             * Exemple :
             *      Func<double, double, double> operation reçoit (a, b) et retourne a * b
             */
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
        /**
         * Converti la string d'opération passée en paramètre en une liste de string.
         * 
         * Exemple :
         *  operations = "1+2.5-8*4/5.25"
         *  
         *  retour : [1.0, "+", 2.5, "-", 8.0, "*", 4.0, "/", 5.25]
        */
        List<string> ConvertirCalculs(string expression)
        {
            // Plusieurs choses à vérifier
            // 1. Enlever tout les whitespaces inutiles
            expression = expression.Replace(" ", "");
            Console.WriteLine($"expression: {string.Join(",", expression.ToArray())}");
            // 1. Vérifier qu'il n'y a pas de caractères bizarres
            foreach(char c in expression)
            {
                // throw
                if (!caracteresValides.Contains(c.ToString()) && !char.IsDigit(c))
                {
                    Console.WriteLine("ERREUR DANS L'ECRITURE DE L'OPERATION");
                    return new List<string>();
                }
            }

            bool numState = true;
            List<string> calculsListe = new List<string>();
            var matches = Regex.Matches(expression, @"\d+|\+|\-|\*|\/|\^|\."); // Utilisation d'un regex pour "splitter" les opérateurs
            foreach (Match match in matches)
            {
                calculsListe.Add(match.ToString());
                Console.WriteLine(match.ToString());
            }
            return new List<string>();

            //// 3. Faire l'insertion de nombre - opérateur - nombre - opérateur - ...
            //for (int i = 0; i < expression.Length; i++)
            //{
            //    char c = expression[i];
            //    /* ERROR CHECKING */
            //    // Si entrée doit être un nombre
            //    if (numState)
            //    {
            //        // Récupérer le nombre i à insérer dans la liste
            //        while (char.IsDigit(c)) // Pour chaque caractère
            //        {
            //            if (!float.TryParse(c.ToString(), out float nombre))
            //            {
            //                Console.Clear();
            //                Console.WriteLine("ERREUR LORS DU PARSING");
            //                break;
            //            }

            //        }
            //    }
            //    else // Si entrée doit être un opérateur
            //    {
            //        if (c.Length != 1 || !"+-/*p=".Contains(c))
            //        {
            //            Console.Clear();
            //            Console.WriteLine("ERREUR LORS DU PARSING");
            //            break;
            //        }
            //    }
            //    // Si l'utilisateur veut le résultat
            //    if (input == "=")
            //    {
            //        double resultat = Calculer(expression);
            //        expression.Clear();
            //        expression.Add(Convert.ToString(resultat));
            //        continue;
            //    }
            //}

            //return new List<string> { expression };
        }

        string EnleverEspaces(string phrase)
        {
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ')
                {
                    phrase.Remove(i);
                }
            }
            Console.WriteLine("Après conversion");
            return phrase;
        }

    }
}
