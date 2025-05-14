namespace BLL
{
    public abstract class Automobile
    {
        protected int annee;
        protected string immatriculation;

        public int Annee
        {
            get => annee;
            set => annee = value;
        }

        public string Immatriculation
        {
            get => immatriculation;
            set => immatriculation = value;
        }

        public Automobile() { }

        public Automobile(int annee, string immatriculation)
        {
            this.annee = annee;
            this.immatriculation = immatriculation;
        }

        public abstract string afficher();
        public override string ToString() => $"{immatriculation}";
    }
}
