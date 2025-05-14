namespace BLL
{
    partial class MotoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.txtImmat = new System.Windows.Forms.TextBox();
            this.txtCylindre = new System.Windows.Forms.TextBox();
            this.txtVitesseMax = new System.Windows.Forms.TextBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblImmat = new System.Windows.Forms.Label();
            this.lblCylindre = new System.Windows.Forms.Label();
            this.lblVitesseMax = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(140, 20);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(150, 20);
            // 
            // txtImmat
            // 
            this.txtImmat.Location = new System.Drawing.Point(140, 60);
            this.txtImmat.Name = "txtImmat";
            this.txtImmat.Size = new System.Drawing.Size(150, 20);
            // 
            // txtCylindre
            // 
            this.txtCylindre.Location = new System.Drawing.Point(140, 100);
            this.txtCylindre.Name = "txtCylindre";
            this.txtCylindre.Size = new System.Drawing.Size(150, 20);
            // 
            // txtVitesseMax
            // 
            this.txtVitesseMax.Location = new System.Drawing.Point(140, 140);
            this.txtVitesseMax.Name = "txtVitesseMax";
            this.txtVitesseMax.Size = new System.Drawing.Size(150, 20);
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(30, 23);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(41, 13);
            this.lblAnnee.Text = "Année:";
            // 
            // lblImmat
            // 
            this.lblImmat.AutoSize = true;
            this.lblImmat.Location = new System.Drawing.Point(30, 63);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(84, 13);
            this.lblImmat.Text = "Immatriculation:";
            // 
            // lblCylindre
            // 
            this.lblCylindre.AutoSize = true;
            this.lblCylindre.Location = new System.Drawing.Point(30, 103);
            this.lblCylindre.Name = "lblCylindre";
            this.lblCylindre.Size = new System.Drawing.Size(52, 13);
            this.lblCylindre.Text = "Cylindrée:";
            // 
            // lblVitesseMax
            // 
            this.lblVitesseMax.AutoSize = true;
            this.lblVitesseMax.Location = new System.Drawing.Point(30, 143);
            this.lblVitesseMax.Name = "lblVitesseMax";
            this.lblVitesseMax.Size = new System.Drawing.Size(85, 13);
            this.lblVitesseMax.Text = "Vitesse maximale:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(50, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 30);
            this.btnOK.Text = "Valider";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(170, 190);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 30);
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // MotoForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 240);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.txtImmat);
            this.Controls.Add(this.txtCylindre);
            this.Controls.Add(this.txtVitesseMax);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblImmat);
            this.Controls.Add(this.lblCylindre);
            this.Controls.Add(this.lblVitesseMax);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "MotoForm";
            this.Text = "Ajouter une Moto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.TextBox txtImmat;
        private System.Windows.Forms.TextBox txtCylindre;
        private System.Windows.Forms.TextBox txtVitesseMax;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblImmat;
        private System.Windows.Forms.Label lblCylindre;
        private System.Windows.Forms.Label lblVitesseMax;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
