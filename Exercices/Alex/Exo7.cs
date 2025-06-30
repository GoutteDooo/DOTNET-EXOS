using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Alex
{
    internal class Exo7
    {

        // EXO 7 - Nombre Mystère
        /*
        Console.WriteLine("--- Trouver le nombre mystère ---\n");

        // -- variables globales --
        // ------------------------

        Random random = new Random(); // seed (?)
        int nombreMystere = random.Next(1, 51); // Nombre mystère entre 1 et 51
        int compteur = 0; // compteur pour le nombre de coups

        // boucle infinie
        while (true)
        {
            // Nouvelle itération == Nouveau coup -> On incrémente le compteur
            compteur++;
            // Demander à l'user de saisir un nombre
            Console.Write("\t Veuillez saisir un nombre: ");
            int input = Convert.ToInt32(Console.ReadLine());
            // Si le nombre est trop petit ou trop grand
            if (input != nombreMystere)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(input < nombreMystere ? "\t\tLe nombre mystère est plus grand." : "\t\tLe nombre mystère est plus petit."); // Affiche l'erreur appropriée
                Console.ResetColor();
                // Relancer la boucle
                continue;
            }
            // Si le nombre est trouvé, féliciter l'utilisateur et afficher le compteur
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nBravo !!!! Vous avez trouvé le nombre mystère!\n\nVous avez trouvé en {compteur} coups.\n");
            Console.ResetColor();
            // Demander à l'utilisateur de fermer le programme
            Console.WriteLine("Appuyez sur la touche Entrée pour fermer le programme...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter); // Il ne se passe rien tant que l'utilisateur n'appuie pas sur "Entrée"
            break;
        }
        */

    }
}
