using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Terrain : Propriete
    {
        private const int NIVEAU_MAX = 5;
        private int niveau;

        public Terrain(TypePropriete type, int pA, int loyer, int coeff) : base(type, pA, loyer, coeff)
        {
            this.niveau = 0;
        }

        // Indique si la propriété peut monter de niveau
        public bool PeutMonterNiveau()
        {
            return 0 <= this.niveau && this.niveau < NIVEAU_MAX;
        }


        // Fait monter de niveau la propriété
        public void MonterNiveau()
        {
            this.niveau++;
        }

        public override void GetEvenement(Joueur j)
        {
            throw new NotImplementedException();
        }

        public override bool Vendable()
        {
            return niveau == 0;
        }

        public int Loyer()
        {
            return (this.niveau * this.coeffNiveauLoyer + 1) * this.loyerBase;
        }
    }
}
