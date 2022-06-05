using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;
using Monopoly;

namespace Propriete
{
    public class Terrain : Propriete
    {
        private const int NIVEAU_MAX = 5;
        private int niveau;

        public Terrain(TypePropriete type, int pA, int loyer, int coeff) : base(type, pA, loyer, coeff)
        {
            this.niveau = 0;
        }

        public override bool PeutMonterNiveau() => 0 <= this.niveau && this.niveau < NIVEAU_MAX;

        public void MonterNiveau()
        {
            Contract.Ensures(this.niveau < NIVEAU_MAX);
            this.niveau++;
        }

        public void BaisserNiveau()
        {
            Contract.Ensures(0 < this.niveau);
            this.niveau--;
        }

        public override void GetEvenement(IJoueur j)
        {
            throw new NotImplementedException();
        }

        public override bool Vendable() => niveau == 0;

        public override int Loyer() => (this.niveau * this.coeffNiveauLoyer + 1) * this.loyerBase;
    }
}
