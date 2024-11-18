using AppConsoleLivres;

internal class Program
{
    // PROGRAMME PRINCIPAL
    private static void Main(string[] args)
    {
        Console.WriteLine("                                      Bienvenue dans notre App de gestiion des Livres");
        Console.WriteLine();
       // Création des 3 instances de la classe Revue
       Revue revue1 = new Revue(1, 2029, "Java programmation", "John Doe", 40);
        Revue revue2 = new Revue(2, 1988, "Le peaupe manding", "Aimer cessair", 50);
        Revue revue3 = new Revue(3, 1999, "Enfant noire", "Camara laye", 45);
        //Affichage des details des objets de Revue
        Console.WriteLine("Détails des Revues :");
        revue1.AfficherDetaille();
        revue2.AfficherDetaille();
        revue3.AfficherDetaille();
        // Création de 3 instances de la classe Roman
        Roman roman1 = new Roman("L'espoir perdue ", "Moussa Diop", 358, "Vie");
        Roman roman2 = new Roman("Probleme 2010 en Guinée", "Mariam", 500, "Greve democratique");
        Roman roman3 = new Roman("L'Étranger polie", "Albert Camus", 320, "Philosophie");
        // Affichage des details des objet de Roman
        Console.WriteLine("\nDétails des Romans :");
        roman1.AfficherDetaille();
        roman2.AfficherDetaille();
        roman3.AfficherDetaille();
        // Création de la liste générique de type Livres
        List<Livre> bibliothequeGuinée = new List<Livre>();
        // Ajout des objets Revue et Roman dans la liste
        bibliothequeGuinée.Add(revue1);
        bibliothequeGuinée.Add(revue2);
        bibliothequeGuinée.Add(revue3);
        bibliothequeGuinée.Add(roman1);
        bibliothequeGuinée.Add(roman2);
        bibliothequeGuinée.Add(roman3);
        // Parcours de la liste et affichage des détails de chaque élément de la liste
        Console.WriteLine("\nDétails de la bibliothèque :");
        foreach (Livre livre in bibliothequeGuinée)
        {
            livre.AfficherDetaille();
        }
        Console.WriteLine();
        Console.WriteLine("                  Fin du programme de App programme livres ");
    }
}