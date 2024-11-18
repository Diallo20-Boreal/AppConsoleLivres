using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    //Création de la classe Revue qui herite de Livre
    internal class Revue : Livre
    {
        // Déclaration des parametres spécifiques à Revue
        public int NumR { get; set; }
        public int Annee { get; set; }
        // Creation du constructeur de la classe Revue
        public Revue(int numR, int annee, string titre, string auteur, int nbPages)
            : base(titre, auteur, nbPages)
        {
            NumR = numR;
            Annee = annee;
        }

        // Création de la méthode AfficherDetaille()
        public override void AfficherDetaille()
        {
            Console.WriteLine($"Revue a pour Numéro: {NumR}, Année: {Annee}, " +
                              $"Titre: {Titre}, Auteur: {Auteur}, Pages: {NbPages}");
        }

    }
}
