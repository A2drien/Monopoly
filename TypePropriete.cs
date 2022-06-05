using System.Collections.Generic;
namespace Monopoly
{
    public class TypePropriete
    {
        private readonly string nom;
        private readonly List<IPropriete> membres;

        public TypePropriete(string nom)
        {
            this.nom = nom;
            this.membres = new List<IPropriete>();
        }

        public void AjouterPropriete(IPropriete p)
        {
            this.membres.Add(p);
        }

        public bool CollectionEntierementDetenue(IJoueur j)
        {
            foreach (IPropriete p in this.membres)
                if (!p.EstPossedePar(j))
                    return false;
            return true;
        }

        public override string ToString() => this.nom;
    }
}