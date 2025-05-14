namespace BLL
{
    partial class VoitureForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Label lblImmatriculation;
        private System.Windows.Forms.TextBox txtImmatriculation;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnAjouter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAnnee = new System.Windows.Forms.Label();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.lblImmatriculation = new System.Windows.Forms.Label();
            this.txtImmatriculation = new System.Windows.Forms.TextBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.lblMarque = new System.Windows.Forms.Label();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(20, 20);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(41, 13);
            this.lblAnnee.TabIndex = 0;
            this.lblAnnee.Text = "Année:";

            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(120, 17);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(150, 20);
            this.txtAnnee.TabIndex = 1;

            // 
            // lblImmatriculation
            // 
            this.lblImmatriculation.AutoSize = true;
            this.lblImmatriculation.Location = new System.Drawing.Point(20, 50);
            this.lblImmatriculation.Name = "lblImmatriculation";
            this.lblImmatriculation.Size = new System.Drawing.Size(81, 13);
            this.lblImmatriculation.TabIndex = 2;
            this.lblImmatriculation.Text = "Immatriculation:";

            // 
            // txtImmatriculation
            // 
            this.txtImmatriculation.Location = new System.Drawing.Point(120, 47);
            this.txtImmatriculation.Name = "txtImmatriculation";
            this.txtImmatriculation.Size = new System.Drawing.Size(150, 20);
            this.txtImmatriculation.TabIndex = 3;

            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(20, 80);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(46, 13);
            this.lblCouleur.TabIndex = 4;
            this.lblCouleur.Text = "Couleur:";

            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(120, 77);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(150, 20);
            this.txtCouleur.TabIndex = 5;

            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(20, 110);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(49, 13);
            this.lblMarque.TabIndex = 6;
            this.lblMarque.Text = "Marque:";

            // 
            // txtMarque
            // 
            this.txtMarque.Location = new System.Drawing.Point(120, 107);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(150, 20);
            this.txtMarque.TabIndex = 7;

            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 140);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";

            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 137);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(150, 20);
            this.txtType.TabIndex = 9;

            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(120, 175);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 30);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // 
            // VoitureForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 230);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.txtAnnee);
            this.Controls.Add(this.lblImmatriculation);
            this.Controls.Add(this.txtImmatriculation);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.txtMarque);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.btnAjouter);
            this.Name = "VoitureForm";
            this.Text = "Nouvelle Voiture";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
