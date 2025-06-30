using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Alex
{
    internal class Exo9
    {
        // EXO 9 - Gestion des notes PARTIE 2

        // -- Variables Globales --
        // ------------------------
        //List<int> notes = new List<int>(); // tableau dyna de notes de longueur 0 à l'initialisation
        //int input;

        //// Boucle infini
        //while(true)
        //{
        //    afficherMenu();
        //    // Demander une entrée utilisateur
        //    input = Convert.ToInt32(Console.ReadLine());
        //    Console.Clear();
        //    if (input < 0 || input > 4) continue; // Si entrée invalide, recommencer
        //    if (input == 0) Environment.Exit(0);
        //    if (input == 1) saisirNotes();
        //    // Si le tableau ne comporte pas encore de notes, interdire l'accès à ces options
        //    if (notes.Count == 0)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Aucune note n'a encore été entrée!");
        //        continue;
        //    }
        //    if (input == 2) afficherNoteMax();
        //    if (input == 3) afficherNoteMin();
        //    if (input == 4) afficherNoteMoy();
        //}

        //void saisirNotes()
        //{
        //    // Colorer en vert
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    // Afficher texte de saisie
        //    Console.WriteLine("------ Saisir les notes ------\n" +
        //        "(999 pour stopper la saisie\n");
        //    // Réinitialiser les couleurs
        //    Console.ResetColor();
        //    // Boucle infinie
        //    while (true)
        //    {
        //        // Demander à l'utilisateur de saisir la note "notes.Length + 1"
        //        Console.Write($"Merci de saisir la note {notes.Count + 1} (sur /20) : ");
        //        bool estEntier = int.TryParse(Console.ReadLine(), out int note);

        //        // Si la note est de 999, break la boucle
        //        if (note == 999) {
        //            // On clear la console pour pouvoir réafficher le menu principal
        //            Console.Clear();
        //            break;
        //        }
        //        // Si la note n'est pas comprise entre 0 et 20 ou que l'utilisateur a fait une erreur de saisie
        //        if (!estEntier || note < 0 || note > 20)
        //        {
        //            // Afficher l'erreur
        //            Console.ForegroundColor= ConsoleColor.Red;
        //            Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
        //            Console.ResetColor();
        //            // Relancer une itération
        //            continue;
        //        }

        //        // Sinon, cela veut dire que l'on a entré une bonne note
        //        notes.Add(note); // Ajouter cette note à la liste
        //    }
        //}

        //static void afficherMenu()
        //{
        //    Console.ResetColor();
        //    Console.Write("--- Gestion des notes avec menu ---\n" +
        //        "1---Saisir les notes\n" +
        //        "2---La plus grande note\n" +
        //        "3---La plus petite note\n" +
        //        "4---La moyenne des notes\n" +
        //        "0---Quitter\n" +
        //        "\n" +
        //        "Faites votre choix: ");
        //}

        //void afficherNoteMax()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("------ La plus grande note ------\n" +
        //        "\n" +
        //        $"La note la plus grande est: {notes.Max()}/20\n");
        //}

        //void afficherNoteMin()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("------ La plus petite note ------\n" +
        //        "\n" +
        //        $"La note la plus petite est : {notes.Min()}/20\n");
        //}

        //void afficherNoteMoy()
        //{
        //    Console.ForegroundColor = ConsoleColor.Blue;
        //    Console.WriteLine("------ La moyenne des notes ------\n" +
        //        "\n" +
        //        $"La note moyenne est de : {Math.Round(notes.Average(), 2)}/20\n");
        //}
        //}



        //Dictionary<string, int> stock = new Dictionary<string, int>();
        ///**
        // * Ajoute le produit au dictionnaire
        // * Si le produit n'existe pas, crée une clé à son nom
        // * */
        //void AjouterProduit(string nom, int quantité)
        //{
        //    if (stock.ContainsKey(nom)) stock[nom] += quantité; else stock[nom] = quantité;
        //}
        ///**
        // * Soustrait la quantité du produit nom
        // * Si la quantité à soustraire est supérieure, renvoie une erreur
        // * Si le produit n'existe pas, renvoie une erreur
        // */
        //void RetirerProduit(string nom, int quantité)
        //{
        //    // soustrait la quantité du produit
        //    // Si le produit n'existe pas
        //    if (!stock.ContainsKey(nom))
        //        throw new ArgumentException($"Le produit {nom} n'existe pas.");

        //    // Si la clé existe
        //    int quantitéRestante = stock[nom];

        //    // Si la quantité demandée est supérieure à ce qu'il reste, on renvoie une erreur
        //    if (quantitéRestante < quantité)
        //        throw new InvalidOperationException($"Quantité insuffisante en stock. Requis: {quantité}, disponible: {quantitéRestante}");

        //    stock[nom] -= quantité;
        //}

        //void AfficherStock()
        //{
        //    Console.WriteLine(string.Join("\n", stock.Select(item => $"{item.Key}: {item.Value}")));
        //}

        //while (true)
        //{
        //    Console.WriteLine("\t1 - Ajouter produit\n" +
        //        "\t2 - Retirer produit\n" +
        //        "\t3- Afficher les produits" +
        //        "\n" +
        //        "\t 0 - Quitter le programme\n");
        //    Console.WriteLine("Choisissez une commande:");
        //    int input = Convert.ToInt32(Console.ReadLine());
        //    if (input == 0) break;
        //    Console.Clear();
        //    if (input == 2) MenuRetirer();
        //    if (input == 1) MenuAjouter();
        //    if (input == 3) AfficherStock();
        //}

        //void MenuAjouter()
        //{
        //    while (true)
        //    {
        //        Console.Write("Entrez le nom du produit à ajouter et sa quantité [produit] [quantité] (stop pour quitter) : ");
        //        string? input = Console.ReadLine();

        //        if (input == "stop") break;

        //        string[] kvInput = input.Split(" ");
        //        AjouterProduit(kvInput[0], Convert.ToInt32(kvInput[1]));
        //        Console.Clear();
        //        Console.WriteLine("Produit ajouté!");
        //    }
        //}

        //void MenuRetirer()
        //{
        //    while (true)
        //    {
        //        Console.Write("Entrez le nom du produit à retirer et sa quantité [produit] [quantité] (stop pour quitter) : ");
        //        string? input = Console.ReadLine();

        //        if (input == "stop") break;

        //        string[] kvInput = input.Split(" ");
        //        RetirerProduit(kvInput[0], Convert.ToInt32(kvInput[1]));
        //        Console.Clear();
        //        Console.WriteLine("Produit retiré!");
        //    }
        //}




    }
}
