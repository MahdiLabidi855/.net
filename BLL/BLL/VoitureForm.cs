using System;
using System.Windows.Forms;

namespace BLL
{
    public partial class VoitureForm : Form
    {
        public string Annee { get; private set; }
        public string Immatriculation { get; private set; }
        public string Couleur { get; private set; }
        public string Marque { get; private set; }
        public string TypeV { get; private set; }
        public Voiture VoitureCreee { get; private set; } // Make sure it's set correctly

        public VoitureForm()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Retrieve input values from the textboxes
            Annee = txtAnnee.Text;
            Immatriculation = txtImmatriculation.Text;
            Couleur = txtCouleur.Text;
            Marque = txtMarque.Text;
            TypeV = txtType.Text;

            // Create the Voiture object
            VoitureCreee = new Voiture(
                int.Parse(Annee), // Assuming Annee is a valid integer
                Immatriculation,
                Couleur,
                Marque,
                TypeV
            );

            // Ensure the Voiture object is created
            if (VoitureCreee != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Erreur lors de la création de la voiture.", "Erreur");
            }
        }
    }
}
