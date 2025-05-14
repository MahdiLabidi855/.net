using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public partial class Form1 : Form
    {
        private Garage monGarage;

        public Form1()
        {
            InitializeComponent();
            monGarage = new Garage("Mon Garage");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (rdbVoiture.Checked)
            {
                VoitureForm formVoiture = new VoitureForm();  
                if (formVoiture.ShowDialog() == DialogResult.OK)
                {
                    Voiture v = formVoiture.VoitureCreee;  
                    if (v != null)
                    {
                        monGarage.addAuto(v);
                        lstAutos.Items.Add(v.Immatriculation);
                    }
                    else
                    {
                        MessageBox.Show("La voiture n'a pas été créée correctement.", "Erreur");
                    }
                }
            }
            else if (rdbMoto.Checked)
            {
                MotoForm formMoto = new MotoForm(); 
                if (formMoto.ShowDialog() == DialogResult.OK)
                {
                    Moto m = formMoto.MotoCreee; 
                    if (m != null)
                    {
                        monGarage.addAuto(m);
                        lstAutos.Items.Add(m.Immatriculation);
                    }
                    else
                    {
                        MessageBox.Show("La moto n'a pas été créée correctement.", "Erreur");
                    }
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstAutos.SelectedItem != null)
            {
                string immat = lstAutos.SelectedItem.ToString();
                monGarage.deleteAuto(immat);  
                lstAutos.Items.Remove(immat);
                lblImmat.Text = lblAnnee.Text = lblType.Text = "";
            }
        }

        private void lstAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAutos.SelectedItem != null)
            {
                string immat = lstAutos.SelectedItem.ToString();
                Automobile a = monGarage.getAuto(immat);

                if (a != null)
                {
                    lblImmat.Text =  "Immatriculation " + a.Immatriculation;
                    lblAnnee.Text = "Annee "  + a.Annee.ToString();
                    lblType.Text = "Name "  + a.GetType().Name;
                }
                else
                {
                    MessageBox.Show("Véhicule non trouvé.", "Erreur");
                }
            }
        }

        private void btnCaracteristiques_Click(object sender, EventArgs e)
        {
            if (lstAutos.SelectedItem != null)
            {
                string immat = lstAutos.SelectedItem.ToString();
                Automobile a = monGarage.getAuto(immat);

                if (a is Moto moto)
                {
                    var infos = new Dictionary<string, string>
            {
                { "Immatriculation", moto.Immatriculation },
                { "Année", moto.Annee.ToString() },
                { "Cylindrée", moto.Cylindre.ToString() },
                { "Vitesse Max", moto.VitesseMax + " km/h" },
                { "Type", "Moto" }
            };

                    InfosForm form = new InfosForm();
                    form.LoadInfos("Infos Moto", infos);
                    form.ShowDialog();
                }
                else if (a is Voiture voiture)
                {
                    // Create dictionary for Voiture's info
                    var infos = new Dictionary<string, string>
            {
                { "Immatriculation", voiture.Immatriculation },
                { "Année", voiture.Annee.ToString() },
                { "Couleur", voiture.Couleur },
                { "Marque", voiture.Marque },
                { "Type", "Voiture" }
            };

                    InfosForm form = new InfosForm();
                    form.LoadInfos("Infos Voiture", infos);
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un véhicule.", "Erreur");
            }
        }
    }
}
