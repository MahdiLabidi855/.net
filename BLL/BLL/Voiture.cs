namespace BLL
{
    public class Voiture : Automobile
    {
        private string couleur;
        private string marque;
        private string typeV;

        public string Couleur { get => couleur; set => couleur = value; }
        public string Marque { get => marque; set => marque = value; }
        public string TypeV { get => typeV; set => typeV = value; }

        public Voiture() { }

        public Voiture(int annee, string immatriculation, string couleur, string marque, string typeV)
            : base(annee, immatriculation)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }

        public override string afficher()
        {
            return $"Voiture - {immatriculation} | {annee} | {couleur} | {marque} | {typeV}";
        }

        public override string ToString() => $"{immatriculation}";
    }
}
