using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
    internal class Livre
    {
        // Declaration des parametre de la classe mère Livre
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbPages { get; set; }

        // Creation du constructeur de la classe Livre
        public Livre(string titre, string auteur, int nbPages)
        {
            Titre = titre;
            Auteur = auteur;
            NbPages = nbPages;
        }

        //  Creation de la méthode pour afficher les détails du livre
        public virtual void AfficherDetaille()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Pages: {NbPages}");
        }
    }

}

