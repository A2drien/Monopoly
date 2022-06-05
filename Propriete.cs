using System;
using System.Collections.Generic;
using System.Text;
using Monopoly;
namespace Propriete
{
    public abstract class Propriete : IPropriete
    {
        private readonly TypePropriete type;
        private readonly int prixAchat;
        private IJoueur proprietaire;
        private protected readonly int loyerBase;
        private protected readonly int coeffNiveauLoyer;
        private bool estHypotequee;

        public Propriete(TypePropriete type, int pA, int loyer, int coeff)
        {
            this.type = type;
            type.AjouterPropriete(this);
            this.prixAchat = pA;
            this.proprietaire = null;
            this.loyerBase = loyer;
            this.coeffNiveauLoyer = coeff;
            this.estHypotequee = false;
        }

        public void Achat(IJoueur j)
        {
            this.proprietaire = j;
        }

        public bool Achetable() => this.proprietaire == null;
        public abstract bool Vendable();
        public abstract int Loyer();
        public abstract void GetEvenement(IJoueur j);
        public abstract bool PeutMonterNiveau();
        public bool EstPossedePar(IJoueur j) => this.proprietaire == j;
        public int GetPrixAchat() => this.prixAchat;
    }
}
