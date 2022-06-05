using System;
using System.Collections.Generic;
using System.Text;
using Monopoly;

namespace Case
{
    public class Plateau
    {
        private IList<IJoueur> joueurs;
        private IList<ICase> cases;

        private const int NB_FACES = 6;

        public Plateau(int nbJoueurs, int argentParJoueur)
        {
            this.joueurs = new List<IJoueur>();
            this.cases = new List<ICase>();
        }

        public static int Lancer()
        {
            return new Random().Next(1, NB_FACES - 1);
        }
    }
}
