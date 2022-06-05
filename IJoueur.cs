using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public interface IJoueur
    {
        public void Acheter(IPropriete p);
        public string ToString();
    }
}
