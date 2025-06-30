using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Complexe
{
    internal class Complexe8
    {
        /* -- MASTERMIND -- */
        /* ---------------- */
        public static void AfficherJeu()
        {
            // Lancement du jeu
            // Affichage générique
            Console.WriteLine("--- MASTERMIND ---");
            // -- Variables globales --
            // ------------------------
            int compteurCouleursBienPlacées,
                compteurCouleursPrésentesMalPlacées,
                nombreDeCoups,
                nbCoupsMax = 10;
            string[] couleursDuMJ = new string[4],
                couleursChoisies = new string[4];
            List<(string[], int, int)> historique = new List<(string[],int,int)>();
            // Générer un ordre aléatoire et le stocker dans une variable string "couleursDuMJ"
            // Demander à l'utilisateur d'entrer les couleurs qu'il souhaite (R V B J par ex)

            /* ---------------------- */
            /* -- BOUCLE DE REPLAY -- */
            /* ---------------------- */
            while (true)
            {
                // Réinitialiser les variables globales
                couleursDuMJ = GénérerCouleursAleatoire();
                compteurCouleursBienPlacées = 0;
                compteurCouleursPrésentesMalPlacées = 0;
                nombreDeCoups = 0;
                couleursChoisies = new string[4];
                historique = new List<(string[],int,int)>();


                /* ------------------------ */
                /* -- BOUCLE DE GAMEPLAY -- */
                /* ------------------------ */
                while (true)
                {
                    //Console.WriteLine($"Test: CouleurMJ: {string.Join(", ", couleursDuMJ.ToArray())}");
                    Console.WriteLine("Veuillez entrer quatre couleurs: [C C C C]" +
                        "Choix possibles : B / G / J / M / N / O / R / V");
                    for (int i = 0; i < 4; i++)
                    {
                        // Stocker ces couleurs dans une variable "couleursChoisies"
                        couleursChoisies[i] = Console.ReadLine();
                    }
                    // Si les couleursChoisies (ainsi que l'ordre) sont déjà présentes dans l'historique,
                    if (VerifierHistorique(couleursChoisies, historique))
                    {
                        // alors, redemander une entrée
                        //Console.WriteLine("dans le if historique");
                        //AfficherHistorique(historique);
                        Console.WriteLine("Erreur! Vous avez déjà choisi ces couleurs, veuillez choisir d'autres couleurs SVP");
                        continue;
                    }
                    // Ou si l'utilisateur a entré une commande inexistante ou oublié une couleur
                    if (ErreurCouleursChoisies(couleursChoisies))
                    {
                        // alors, redemander une entrée
                        Console.WriteLine("Erreur! Veuillez choisir d'autres couleurs SVP");
                        continue;
                    }
                    // Sinon
                    // Réinitialiser compteurCouleursBienPlacées et compteurCouleurPrésentesMalPlacées à 0
                    compteurCouleursBienPlacées = 0;
                    compteurCouleursPrésentesMalPlacées = 0;
                    // Pour chaque couleurChoisie à l'index i de couleurChoisies
                    for (int i = 0; i < couleursChoisies.Length; i++)
                    {
                        // si la couleurChoisie à l'index i est égale à la couleursDuMJ à l'index i,
                        if (couleursChoisies[i] == couleursDuMJ[i])
                            // alors, incrémenter compteurCouleurBienPlacées de 1
                            compteurCouleursBienPlacées++;

                        // si la couleurChoisie existe dans couleursDuMJ mais que leur index est différent,
                        if (couleursDuMJ.Contains(couleursChoisies[i]) && couleursChoisies[i] != couleursDuMJ[i])
                            compteurCouleursPrésentesMalPlacées++;
                        // alors, incrémenter compteurCouleursPrésentesMalPlacées de 1
                    }
                    Console.Clear();
                    historique.Add((couleursChoisies, compteurCouleursBienPlacées, compteurCouleursPrésentesMalPlacées));
                    AfficherHistorique(historique);

                    // Afficher compteurCouleursBienPlacées et compteurCouleursPrésentesMalPlacées
                    Console.WriteLine($"\tCouleurs bien placées: {compteurCouleursBienPlacées}\n" +
                        $"\tCouleurs présentes mal placées: {compteurCouleursPrésentesMalPlacées}");

                    // Si compteurCouleurBienPlacées vaut 4, alors le joueur gagne la partie
                    if (compteurCouleursBienPlacées == 4)
                    {
                        // On le félicite et on lui demande pour une nouvelle partie
                        Console.WriteLine($"Félicitations!! Vous avez réussi en {++nombreDeCoups} coups !");
                        break;
                    }

                    // Sinon, incrémenter nombreDeCoups de 1
                    nombreDeCoups++;
                    // Ajouter le tableau de string de couleurChoisies à l'historique
                    // Si nombreDeCoups atteint 10, le joueur perd la partie
                    if (nombreDeCoups == nbCoupsMax)
                    {
                        Console.WriteLine($"Vous avez atteint 10 coups joués, dommage, vous perdez la partie!n" +
                            $"La combinaison du MJ était: {string.Join(", ", couleursDuMJ.ToArray())}");
                        break;
                    }
                    couleursChoisies = new string[4]; // réinitialiser couleursChoisies
                    Console.WriteLine($"Il vous reste {nbCoupsMax - nombreDeCoups} coups restants.");
                    // et on lui demande pour une nouvelle partie
                    // Sinon, répéter la boucle
                }

                Console.Write("Souhaitez-vous rejouer une nouvelle partie ? (Y/n)");
                string replay = Console.ReadLine();
                if (replay == "Y" || replay == "y")
                {
                    Console.Clear();
                    continue;
                }
                // la partie se termine
                break;
            }
        }

        /**
         * Parcourt l'historique et vérifie si le tableau de string couleurs passé en paramètre existe
         * Retourne:
         *      True si couleursChoisies y est
         *      False sinon
         */
        static bool VerifierHistorique(string[] couleurs, List<(string[],int,int)> historique)
        {
                        //Console.WriteLine("dans la fonction verifierHistorique");
            //AfficherHistorique(historique);
            for (int i = 0; i < historique.Count; i++)
            {
                string[] couleurHisto = historique[i].Item1;
                //Console.WriteLine($"historique vérifié: {string.Join(" ,", historique[i].ToArray())}");
                //Console.WriteLine($"couleurs vérifiées: {string.Join(" ,", couleurs.ToArray())}");
                if (couleursCorrespondent(couleurs, couleurHisto))
                    return true;
            }
            return false;
        }

        /**
         * Vérifie que les deux choix de couleurs sont exactement les mêmes
         * Retourne :
         *      True si les deux choix de couleurs sont dans le même ordre
         *      False si les deux choix de couleurs sont différentes
         */
        static bool couleursCorrespondent(string[] couleursA, string[] couleursB)
        {
            int nbCouleurs = couleursA.Length;
            int compteur = 0; // Si compteur atteint nbCouleurs, alors les couleurs correspondent
            //Console.WriteLine("fonc: couleursCorrespondent");
            for (int i = 0; i < nbCouleurs; i++)
            {
                //Console.WriteLine($"CouleurA[{i}]: {couleursA[i]}");
                //Console.WriteLine($"CouleurB[{i}]: {couleursB[i]}");
                if (couleursA[i] == couleursB[i])
                {
                    //Console.WriteLine($"{couleursA[i]} - {couleursB[i]} ");
                    compteur++;
                }
            }
            return compteur == 4;
        }
        /**
         * Génère 4 couleurs aléatoires pour le Maitre de Jeu
         * retourne:
         *     un tableau de string contenant quatre couleurs différentes
         */
        static string[] GénérerCouleursAleatoire()
        {
            List<string> couleursAChoisir = new List<string> { "Jaune", "Rouge", "Bleu", "Vert", "Noir", "Gris", "Marron", "Orange" };
            string[] couleursChoisies = new string[4];
            Random rng = new Random();
            for (int i = 0; i < 4; i++)
            {
                int indexAleatoire = rng.Next(couleursAChoisir.Count);
                couleursChoisies[i] = couleursAChoisir[indexAleatoire][0].ToString();
                couleursAChoisir.Remove(couleursAChoisir[indexAleatoire]);
            }
            //Console.WriteLine("couleurs aléatoires: " + string.Join(", ", couleursAChoisir.ToArray()));
            return couleursChoisies;
        }
        public static bool ErreurCouleursChoisies(string[] couleurs)
        {
            // TEST: Console.WriteLine($"ErreurCouleursChoisies: {string.Join(",",couleurs.ToArray())}");
            string valides = "BGJMNORV";
            for (int i = 0; i < couleurs.Length; i++)
            {
                // Vérifier si chaque couleur est bien entrée
                if (!valides.Contains(couleurs[i]))
                    return true;
            }
            // Si la vérification est passée, alors
            return false;
        }

        public static void AfficherHistorique(List<(string[],int,int)> historique)
        {
            Console.WriteLine("------ HISTORIQUE ------\n" +
                              "------------------------   B | M");
            foreach ((string[],int,int) histo in historique)
            {
                Console.WriteLine("Coup n°" + (historique.IndexOf(histo) + 1) + " : " + string.Join(" | ", histo.Item1.ToArray()) + "   " + histo.Item2 + " | " + histo.Item3);
            }
            Console.WriteLine();
        }
    }
}
