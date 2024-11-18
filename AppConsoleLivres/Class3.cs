using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsoleLivres
{
// Création de la classe fille Roman qui herite la classe mere Livre
    internal class Roman : Livre
    {
        public string Genre { get; set; }

        // Constructeur de la classe Roman
        public Roman(string titre, string auteur, int nbPages, string genre)
            : base(titre, auteur, nbPages)
        {
            Genre = genre;
        }

        // Définition de la méthode AfficherDetaille
        public override void AfficherDetaille()
        {
            Console.WriteLine($"Roman - Titre: {Titre}, Auteur: {Auteur}, Pages: {NbPages}, Genre: {Genre}");
        }
    }
}
