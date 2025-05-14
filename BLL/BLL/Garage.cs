using System.Collections.Generic;

namespace BLL
{
    public class Garage
    {
        private string adresse;
        private List<Automobile> autos = new List<Automobile>();

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public Garage() { }

        public Garage(string adresse)
        {
            this.adresse = adresse;
        }

        public void addAuto(Automobile auto) => autos.Add(auto);

        public void deleteAuto(string immatriculation)
        {
            var auto = getAuto(immatriculation);
            if (auto != null)
                autos.Remove(auto);
        }

        public List<Automobile> afficherAutomobiles() => autos;

        public Automobile getAuto(string immatriculation)
        {
            return autos.Find(a => a.Immatriculation == immatriculation);
        }

        public int getIndexAuto(string immatriculation)
        {
            return autos.FindIndex(a => a.Immatriculation == immatriculation);
        }

        public void updateAuto(string immatriculation, Automobile newAuto)
        {
            int index = getIndexAuto(immatriculation);
            if (index != -1)
                autos[index] = newAuto;
        }
    }
}
