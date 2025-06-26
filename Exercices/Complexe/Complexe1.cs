using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_DAY2.Exercices.Complexe
{
    internal class Complexe1
    {
        // -------------------------
        // -- EXERCICES COMPLEXES --
        // -------------------------

        /* --  EXERCICE 1  -- */
        /* --  ANALYSE TXT -- */
        /* ------------------ */
        /**
         * Retourne un objet contenant 
         * - Le nombre total de mots dans texte
         * - Les 5 mots les plus fréquents
         * - La liste des mots qui n'apparaissent qu'une seule fois
         * 
        */
        
        //RésultatAnalyse AnalyserTexte(string texte)
        //{
        //    int totalMots;
        //    string[] cinqPlusFrequents = new string[5];
        //    List<string> apparaissentUneSeuleFois = new List<string>();

        //    // Remplacer les caractères spéciaux
        //    const string specialChars = "'(),:;.@";
        //    // Comme son nom l'indique, StringBuilder permet de pouvoir construire une string mutable
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 0; i < texte.Length; i++)
        //    {
        //        char c = texte[i];
        //        // Trouver quel est le caractère spécial et le remplacer
        //        if (specialChars.Contains(texte[i]))
        //        {
        //            result.Append(' ');
        //            continue;
        //        }
        //        //Si pas de caractère spécial trouvé, on ajoute le char du texte en lowercase pour normaliser
        //        result.Append(c.ToString().ToLower());
        //    }

        //    // récupérer l'objet sous forme de string
        //    string texteParse = result.ToString();
        //    // On insère dans un tableau de string,
        //    // On split les tabulations, retours à la ligne etc... et on supprime les éléments vides ("") du nouveau tableau
        //    // Puis, on reprend ce même tableau et avec la méthode Where(), on filtre les éléments qui ne sont pas que des whitespaces
        //    // Enfin, on le convertit en Array car Where a converti en IEnumerable
        //    string[] mots = texteParse
        //        .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Where(m => !string.IsNullOrWhiteSpace(m))
        //        .ToArray();

        //    string textePropre = string.Join(" ", mots);

        //    string[] tableauTextePropre = textePropre.Split(" ");
        //    /* Total des mots */
        //    totalMots = tableauTextePropre.Length;

        //    /* --- TROUVER LES CINQ PLUS FREQUENTS --- */
        //    /* --------------------------------------- */
        //    // Parcourir le tableau et faire le compte de tous les mots
        //    // Pour chaque substring
        //    Dictionary<string, int> compteur = new Dictionary<string, int>();
        //    foreach (string s in tableauTextePropre)
        //    {
        //        // Si la substring se trouve dans le dictionnaire,
        //        if (compteur.ContainsKey(s))
        //        {
        //            // Incrémenter le compteur de cette substring
        //            compteur[s]++;
        //        }
        //        else
        //        {
        //            // Sinon, créer une nouvelle clé et y insérer une valeur de 1
        //            compteur[s] = 1;
        //        }
        //    }
        //    // Maintenant que l'on a notre dictionnaire de prêt,
        //    // On va trier par ordre de fréquence
        //    var compteurTrié = from entry in compteur orderby entry.Value descending select entry;
        //    // Maintenant que l'on a trié le dictionnaire compteur, on ne garde uniquement que les cinq premières clés
        //    int index = 0;
        //    foreach (var pair in compteurTrié)
        //    {
        //        if (index == 5) break;
        //        cinqPlusFrequents[index] = pair.Key;
        //        index++;
        //        Console.WriteLine($"Fréquence de '{pair.Key}' => {pair.Value}");
        //    }

        //    /* Trouver ceux qui n'apparaissent qu'une seule fois */
        //    foreach (var pair in compteurTrié)
        //    {
        //        if (pair.Value == 1)
        //        {
        //            apparaissentUneSeuleFois.Add(pair.Key);
        //        }
        //    }

        //    /* Retourne l'objet attendu */
        //    return new RésultatAnalyse
        //    {
        //        TotalMots = totalMots,
        //        CinqPlusFrequents = cinqPlusFrequents,
        //        ApparaissentUneSeuleFois = apparaissentUneSeuleFois
        //    };
        //}

        //string texte = @"
        //        Article labellisé du jour.
        //        Le roi Albert au début de l'année 1915.
        //        Albert, né le 8 avril 1875 à Bruxelles (Belgique) et mort le 17 février 1934 à Marche-les-Dames (Belgique), est roi des Belges de 1909 à 1934. Duc de Saxe, prince de Saxe-Cobourg et Gotha et héritier de la couronne belge de 1905 à 1909, il devient le troisième souverain de Belgique après la mort de son oncle Léopold II.

        //        Le jour du 2 octobre 1900, il épouse Élisabeth en Bavière, avec laquelle il partage une vision humaniste et pacifiste de la société. Le roi et la reine forment un couple très vite populaire et donnent une image modernisée de la monarchie, dont ils renouvellent le style. Issu d'une lignée aux racines germaniques et mari d'une princesse allemande, le roi choisit en 1914 de défendre son pays, pourtant créé neutre, et de combattre contre l'invasion allemande, affirmant le caractère belge de sa dynastie.

        //        À partir de la Première Guerre mondiale, Albert devient l'objet d'un véritable mythe dépassant largement le cadre des frontières belges, recueillant les surnoms guerriers de Roi Soldat ou de Roi Chevalier. Après l'armistice de 1918, le roi intervient fréquemment dans les questions politiques belges. En 1919, alors que la Constitution borne ses pouvoirs, il réussit lors de l'entrevue de Lophem à convaincre les hommes politiques belges les plus éminents de la nécessité d'adopter le suffrage universel masculin pur et simple.

        //        Le roi prône l'égalité effective des deux langues nationales, la reconnaissance de la liberté syndicale, l'extension de la législation sociale et l'essor des sciences. Sur le plan des relations internationales, il accomplit de longs voyages officiels et privés à l'étranger : les États-Unis en 1919, le Brésil l'année suivante, les Indes en 1925, sans oublier le Congo en 1928 et en 1932 et enfin la Syrie et la Palestine en 1933.

        //        Passionné d'alpinisme, comptant à son actif plusieurs ascensions importantes, il fait une chute mortelle en 1934, dans la vallée de la Meuse en Belgique. Son fils aîné lui succède sous le nom de Léopold III.
        //        ";

        //RésultatAnalyse resultat = AnalyserTexte(texte);
        //resultat.AfficherProprietes();
    }

    //public class RésultatAnalyse
    //{
    //    public int TotalMots { get; set; }
    //    public string[] CinqPlusFrequents { get; set; }
    //    public List<string> ApparaissentUneSeuleFois { get; set; }

    //    public void AfficherProprietes()
    //    {
    //        Console.WriteLine($"totalMots: {TotalMots}\n" +
    //            $"Les cinq + fréquents: {string.Join(", ", CinqPlusFrequents)}\n" +
    //            $"N'apparaissent qu'une seule fois: {string.Join(", ", ApparaissentUneSeuleFois)}");
    //    }
    //}
}
