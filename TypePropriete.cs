using System.Collections.Generic;
namespace Monopoly
{
    public class TypePropriete
    {
        private readonly string nom;
        private readonly List<Propriete> membres;

        public TypePropriete(string nom)
        {
            this.nom = nom;
            this.membres = new List<Propriete>();
        }

        public void AjouterPropriete(Propriete p)
        {
            this.membres.Add(p);
        }
    }
}