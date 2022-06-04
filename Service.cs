using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public class Service : Propriete
    {
        public Service(TypePropriete type, int pA, int loyer, int coeff) : base(type, pA, loyer, coeff)
        {

        }

        public override void GetEvenement(Joueur j)
        {
            throw new NotImplementedException();
        }

        public override bool Vendable()
        {
            return true;
        }
    }
}
