using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Propriete : ICase
    {
        private readonly TypePropriete type;
        public readonly int prixAchat;
        private Joueur proprietaire;
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

        public void Achat(Joueur j)
        {
            this.proprietaire = j;
        }

        // Indique le prix du loyer actuel

        // Indique si la propriété est achetable
        public bool Achetable()
        {
            return this.proprietaire == null;
        }

        public abstract bool Vendable();

        public abstract void GetEvenement(Joueur j);
    }
}
