using System.Collections.Generic;
using Monopoly;
using System.Diagnostics.Contracts;

namespace Joueur
{
    public abstract class Joueur : IJoueur
    {
        private readonly string nom;
        private int argent;
        private readonly List<IPropriete> proprietes;

        public Joueur(string nom, int argent)
        {
            this.nom = nom;
            this.argent = argent;
            this.proprietes = new List<IPropriete>();
        }

        private bool Achetable(IPropriete p) => p.GetPrixAchat() <= this.argent;

        public void Acheter(IPropriete p)
        {
            if (!Achetable(p)) throw new System.ArgumentException(this + " n'a pas assez d'argent pour acheter " + p);
            this.argent -= p.GetPrixAchat();
            this.proprietes.Add(p);
        }

        public override string ToString() => this.nom;
    }
}