using System.Collections.Generic;
namespace Monopoly
{
    public class Joueur
    {
        private readonly string nom;
        private int argent;
        private List<Propriete> proprietes;

        public Joueur(string nom, int argent)
        {
            this.nom = nom;
            this.argent = argent;
            this.proprietes = new List<Propriete>();
        }

        public void Acheter(Propriete p) 
        {
            this.argent -= p.prixAchat;
            this.proprietes.Add(p);
        }
    }
}