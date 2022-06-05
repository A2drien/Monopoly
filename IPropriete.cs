namespace Monopoly
{
    public interface IPropriete : ICase
    {
        public bool Achetable();
        public int Loyer();
        public bool PeutMonterNiveau();
        public bool Vendable();
        public int GetPrixAchat();
        public bool EstPossedePar(IJoueur j);
    }
}