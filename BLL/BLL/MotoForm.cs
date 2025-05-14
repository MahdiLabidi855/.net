using System;
using System.Windows.Forms;

namespace BLL
{
    public partial class MotoForm : Form
    {
        public Moto MotoCreee { get; private set; }

        public MotoForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int annee = int.Parse(txtAnnee.Text);
                string immatriculation = txtImmat.Text;
                int cylindre = int.Parse(txtCylindre.Text);
                int vitesseMax = int.Parse(txtVitesseMax.Text);

                MotoCreee = new Moto(annee, immatriculation, cylindre, vitesseMax);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de saisie : " + ex.Message);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
