using System;
using System.Collections.Generic;
using Monopoly;
namespace Case
{
    public class CasePrison : ICase
    {
        private const int NB_TOURS_MAX = 3;
        private readonly IDictionary<IJoueur, int> prisonniers;

        public CasePrison()
        {
            this.prisonniers = new Dictionary<IJoueur, int>();
        }

        public void GetEvenement(IJoueur j)
        {
            if (EstDetenu(j))
                if (PeutSortir(j))
                    Sortie(j);
                else
                    TentativeEvasion(j);
            else
                SimpleVisite(j);
        }

        // Doit faire un double
        private void TentativeEvasion(IJoueur j)
        {
            if (Plateau.Lancer() == Plateau.Lancer())
                PeutSortir(j);
            else
                Reste(j);
        }

        public void NouvelArrivant(IJoueur j) => this.prisonniers.Add(j, 0);
        private void Sortie(IJoueur j) => this.prisonniers.Remove(j);
        private void Reste(IJoueur j) => this.prisonniers.Add(j, this.prisonniers[j] + 1);
        private bool EstDetenu(IJoueur j) => this.prisonniers.ContainsKey(j);
        private bool PeutSortir(IJoueur j) => this.prisonniers[j] >= NB_TOURS_MAX;
        private void SimpleVisite(IJoueur j) => IHM.VisitePrison(j, new List<IJoueur>(this.prisonniers.Keys));
    }
}
