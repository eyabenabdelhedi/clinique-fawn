namespace CliniqueVeterinaire
{
    partial class FormMenuVeterinaire
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

        private void InitializeComponent()
        {
            this.lblBienvenue = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnHistorique = new System.Windows.Forms.Button();
            this.btnVaccinations = new System.Windows.Forms.Button();
            this.btnConsultations = new System.Windows.Forms.Button();
            this.btnPlanning = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblBienvenue.Location = new System.Drawing.Point(149, 59);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(115, 30);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(460, 410);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(140, 38);
            this.btnDeconnexion.TabIndex = 13;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnHistorique
            // 
            this.btnHistorique.BackColor = System.Drawing.Color.Plum;
            this.btnHistorique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorique.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHistorique.Location = new System.Drawing.Point(131, 349);
            this.btnHistorique.Name = "btnHistorique";
            this.btnHistorique.Size = new System.Drawing.Size(330, 55);
            this.btnHistorique.TabIndex = 16;
            this.btnHistorique.Text = "📋  Historique Animaux";
            this.btnHistorique.UseVisualStyleBackColor = false;
            this.btnHistorique.Click += new System.EventHandler(this.btnHistorique_Click);
            // 
            // btnVaccinations
            // 
            this.btnVaccinations.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnVaccinations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaccinations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVaccinations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaccinations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVaccinations.Location = new System.Drawing.Point(131, 278);
            this.btnVaccinations.Name = "btnVaccinations";
            this.btnVaccinations.Size = new System.Drawing.Size(330, 55);
            this.btnVaccinations.TabIndex = 15;
            this.btnVaccinations.Text = "💉  Vaccinations";
            this.btnVaccinations.UseVisualStyleBackColor = false;
            this.btnVaccinations.Click += new System.EventHandler(this.btnVaccinations_Click);
            // 
            // btnConsultations
            // 
            this.btnConsultations.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConsultations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnConsultations.Location = new System.Drawing.Point(131, 205);
            this.btnConsultations.Name = "btnConsultations";
            this.btnConsultations.Size = new System.Drawing.Size(330, 55);
            this.btnConsultations.TabIndex = 14;
            this.btnConsultations.Text = "🩺  Consultations";
            this.btnConsultations.UseVisualStyleBackColor = false;
            this.btnConsultations.Click += new System.EventHandler(this.btnConsultations_Click);
            // 
            // btnPlanning
            // 
            this.btnPlanning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(185)))));
            this.btnPlanning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlanning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPlanning.Location = new System.Drawing.Point(131, 134);
            this.btnPlanning.Name = "btnPlanning";
            this.btnPlanning.Size = new System.Drawing.Size(330, 55);
            this.btnPlanning.TabIndex = 12;
            this.btnPlanning.Text = "📅  Mon Planning";
            this.btnPlanning.UseVisualStyleBackColor = false;
            this.btnPlanning.Click += new System.EventHandler(this.btnPlanning_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel.Controls.Add(this.lblTitre);
            this.panel.Controls.Add(this.lblBienvenue);
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 110);
            this.panel.TabIndex = 11;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitre.Location = new System.Drawing.Point(87, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(491, 50);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🐾 MENU VÉTÉRINAIRE🐾";
            // 
            // FormMenuVeterinaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnHistorique);
            this.Controls.Add(this.btnVaccinations);
            this.Controls.Add(this.btnConsultations);
            this.Controls.Add(this.btnPlanning);
            this.Controls.Add(this.panel);
            this.Name = "FormMenuVeterinaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique Fawn - Menu Vétérinaire";
            this.Load += new System.EventHandler(this.FormMenuVeterinaire_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnHistorique;
        private System.Windows.Forms.Button btnVaccinations;
        private System.Windows.Forms.Button btnConsultations;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitre;
    }
}
