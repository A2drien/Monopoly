using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public static class IHM
    {
        public static void AnnoncerArrivee(IJoueur j, ICase c)
        {
            Console.WriteLine(j + " arrive sur la case " + c);
        }

        internal static void VisitePrison(IJoueur j, IReadOnlyList<IJoueur> listeDetenus)
        {
            
        }
    }
}
