namespace CliniqueVeterinaire
{
    partial class FormMenuSecretaire
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
            this.panel = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnFactures = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.btnAnimaux = new System.Windows.Forms.Button();
            this.btnProprietaires = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblBienvenue.Location = new System.Drawing.Point(113, 59);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(121, 30);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue ";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel.Controls.Add(this.lblTitre);
            this.panel.Controls.Add(this.lblBienvenue);
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 110);
            this.panel.TabIndex = 1;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitre.Location = new System.Drawing.Point(87, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(466, 50);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🐾 MENU SECRÉTAIRE🐾";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(470, 406);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(140, 38);
            this.btnDeconnexion.TabIndex = 7;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnFactures
            // 
            this.btnFactures.BackColor = System.Drawing.Color.Plum;
            this.btnFactures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactures.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactures.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFactures.Location = new System.Drawing.Point(141, 345);
            this.btnFactures.Name = "btnFactures";
            this.btnFactures.Size = new System.Drawing.Size(330, 55);
            this.btnFactures.TabIndex = 10;
            this.btnFactures.Text = "💰  Factures";
            this.btnFactures.UseVisualStyleBackColor = false;
            this.btnFactures.Click += new System.EventHandler(this.btnFactures_Click);
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnRendezVous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRendezVous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRendezVous.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezVous.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRendezVous.Location = new System.Drawing.Point(141, 274);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(330, 55);
            this.btnRendezVous.TabIndex = 9;
            this.btnRendezVous.Text = "📅  Rendez-vous";
            this.btnRendezVous.UseVisualStyleBackColor = false;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click);
            // 
            // btnAnimaux
            // 
            this.btnAnimaux.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnimaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimaux.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimaux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAnimaux.Location = new System.Drawing.Point(141, 201);
            this.btnAnimaux.Name = "btnAnimaux";
            this.btnAnimaux.Size = new System.Drawing.Size(330, 55);
            this.btnAnimaux.TabIndex = 8;
            this.btnAnimaux.Text = "🐶  Gestion Animaux";
            this.btnAnimaux.UseVisualStyleBackColor = false;
            this.btnAnimaux.Click += new System.EventHandler(this.btnAnimaux_Click);
            // 
            // btnProprietaires
            // 
            this.btnProprietaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(185)))));
            this.btnProprietaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProprietaires.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProprietaires.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProprietaires.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnProprietaires.Location = new System.Drawing.Point(141, 130);
            this.btnProprietaires.Name = "btnProprietaires";
            this.btnProprietaires.Size = new System.Drawing.Size(330, 55);
            this.btnProprietaires.TabIndex = 6;
            this.btnProprietaires.Text = "👤  Gestion Propriétaires";
            this.btnProprietaires.UseVisualStyleBackColor = false;
            this.btnProprietaires.Click += new System.EventHandler(this.btnProprietaires_Click);
            // 
            // FormMenuSecretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnFactures);
            this.Controls.Add(this.btnRendezVous);
            this.Controls.Add(this.btnAnimaux);
            this.Controls.Add(this.btnProprietaires);
            this.Controls.Add(this.panel);
            this.Name = "FormMenuSecretaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique Fawn - Menu Secrétaire";
            this.Load += new System.EventHandler(this.FormMenuSecretaire_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnFactures;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.Button btnAnimaux;
        private System.Windows.Forms.Button btnProprietaires;
    }
}
