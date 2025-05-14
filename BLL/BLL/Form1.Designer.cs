namespace BLL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton rdbVoiture;
        private System.Windows.Forms.RadioButton rdbMoto;
        private System.Windows.Forms.ListBox lstAutos;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblImmat;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnCaracteristiques;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rdbVoiture = new System.Windows.Forms.RadioButton();
            this.rdbMoto = new System.Windows.Forms.RadioButton();
            this.lstAutos = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblImmat = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnCaracteristiques = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // rdbVoiture
            this.rdbVoiture.AutoSize = true;
            this.rdbVoiture.Location = new System.Drawing.Point(12, 12);
            this.rdbVoiture.Name = "rdbVoiture";
            this.rdbVoiture.Size = new System.Drawing.Size(58, 17);
            this.rdbVoiture.TabIndex = 0;
            this.rdbVoiture.TabStop = true;
            this.rdbVoiture.Text = "Voiture";
            this.rdbVoiture.UseVisualStyleBackColor = true;

            // rdbMoto
            this.rdbMoto.AutoSize = true;
            this.rdbMoto.Location = new System.Drawing.Point(76, 12);
            this.rdbMoto.Name = "rdbMoto";
            this.rdbMoto.Size = new System.Drawing.Size(49, 17);
            this.rdbMoto.TabIndex = 1;
            this.rdbMoto.TabStop = true;
            this.rdbMoto.Text = "Moto";
            this.rdbMoto.UseVisualStyleBackColor = true;

            // lstAutos
            this.lstAutos.FormattingEnabled = true;
            this.lstAutos.Location = new System.Drawing.Point(12, 35);
            this.lstAutos.Name = "lstAutos";
            this.lstAutos.Size = new System.Drawing.Size(113, 160);
            this.lstAutos.TabIndex = 2;
            this.lstAutos.SelectedIndexChanged += new System.EventHandler(this.lstAutos_SelectedIndexChanged);

            // btnAjouter
            this.btnAjouter.Location = new System.Drawing.Point(12, 201);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(53, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // btnSupprimer
            this.btnSupprimer.Location = new System.Drawing.Point(71, 201);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(70, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // lblTitre
            this.lblTitre.BackColor = System.Drawing.Color.LightYellow;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitre.Location = new System.Drawing.Point(140, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(180, 30);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Mon Garage";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblImmat
            this.lblImmat.Location = new System.Drawing.Point(140, 50);
            this.lblImmat.Name = "lblImmat";
            this.lblImmat.Size = new System.Drawing.Size(180, 23);
            this.lblImmat.Text = "Immatriculation";

            // lblAnnee
            this.lblAnnee.Location = new System.Drawing.Point(140, 80);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(180, 23);
            this.lblAnnee.Text = "Année";

            // lblType
            this.lblType.Location = new System.Drawing.Point(140, 110);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(180, 23);
            this.lblType.Text = "Type";

            // btnCaracteristiques
            this.btnCaracteristiques.Location = new System.Drawing.Point(220, 201);
            this.btnCaracteristiques.Name = "btnCaracteristiques";
            this.btnCaracteristiques.Size = new System.Drawing.Size(100, 23);
            this.btnCaracteristiques.TabIndex = 6;
            this.btnCaracteristiques.Text = "Caractéristiques";
            this.btnCaracteristiques.UseVisualStyleBackColor = true;
            this.btnCaracteristiques.Click += new System.EventHandler(this.btnCaracteristiques_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(334, 241);
            this.Controls.Add(this.rdbVoiture);
            this.Controls.Add(this.rdbMoto);
            this.Controls.Add(this.lstAutos);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblImmat);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnCaracteristiques);
            this.Name = "MainForm";
            this.Text = "Mon Garage";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
