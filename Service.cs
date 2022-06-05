using System;
using System.Collections.Generic;
using System.Text;
using Monopoly;
namespace Propriete
{
    public class Service : Propriete
    {
        public Service(TypePropriete type, int pA, int loyer, int coeff) : base(type, pA, loyer, coeff)
        {

        }

        public override void GetEvenement(IJoueur j)
        {
            throw new NotImplementedException();
        }

        public override int Loyer() => throw new NotImplementedException();
        public override bool PeutMonterNiveau() => false;
        public override bool Vendable() => true;
    }
}
