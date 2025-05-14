namespace BLL
{
    public class Moto : Automobile
    {
        public int Cylindre { get; set; }
        public int VitesseMax { get; set; }

        public Moto() { }

        public Moto(int annee, string immatriculation, int cylindre, int vitesseMax)
            : base(annee, immatriculation)
        {
            Cylindre = cylindre;
            VitesseMax = vitesseMax;
        }

        public override string afficher()
        {
            return $"Moto - {Immatriculation} | {Annee} | {Cylindre}cc | Max {VitesseMax} km/h";
        }

        public override string ToString() => $"{Immatriculation}";
    }
}
