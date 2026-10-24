namespace CliniqueVeterinaire
{
    partial class FormMenuAdmin
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
            this.btnUtilisateurs = new System.Windows.Forms.Button();
            this.btnTableauBord = new System.Windows.Forms.Button();
            this.btnMedicaments = new System.Windows.Forms.Button();
            this.btnStatistiques = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.AutoSize = true;
            this.lblBienvenue.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblBienvenue.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenue.Location = new System.Drawing.Point(79, 59);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(193, 30);
            this.lblBienvenue.TabIndex = 0;
            this.lblBienvenue.Text = "Bienvenue Admin:";
            this.lblBienvenue.Click += new System.EventHandler(this.lblBienvenue_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel.Controls.Add(this.lblTitre);
            this.panel.Controls.Add(this.lblBienvenue);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 110);
            this.panel.TabIndex = 2;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitre.Location = new System.Drawing.Point(11, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(581, 50);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🐾 MENU ADMINISTRATEUR🐾";
            this.lblTitre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // btnUtilisateurs
            // 
            this.btnUtilisateurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(233)))), ((int)(((byte)(185)))));
            this.btnUtilisateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateurs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUtilisateurs.Location = new System.Drawing.Point(151, 127);
            this.btnUtilisateurs.Name = "btnUtilisateurs";
            this.btnUtilisateurs.Size = new System.Drawing.Size(330, 55);
            this.btnUtilisateurs.TabIndex = 0;
            this.btnUtilisateurs.Text = "👥  Gestion Utilisateurs";
            this.btnUtilisateurs.UseVisualStyleBackColor = false;
            this.btnUtilisateurs.Click += new System.EventHandler(this.btnUtilisateurs_Click);
            // 
            // btnTableauBord
            // 
            this.btnTableauBord.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTableauBord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTableauBord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTableauBord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableauBord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnTableauBord.Location = new System.Drawing.Point(151, 198);
            this.btnTableauBord.Name = "btnTableauBord";
            this.btnTableauBord.Size = new System.Drawing.Size(330, 55);
            this.btnTableauBord.TabIndex = 3;
            this.btnTableauBord.Text = "📊  Tableau de Bord";
            this.btnTableauBord.UseVisualStyleBackColor = false;
            this.btnTableauBord.Click += new System.EventHandler(this.btnTableauBord_Click);
            // 
            // btnMedicaments
            // 
            this.btnMedicaments.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnMedicaments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicaments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedicaments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMedicaments.Location = new System.Drawing.Point(151, 271);
            this.btnMedicaments.Name = "btnMedicaments";
            this.btnMedicaments.Size = new System.Drawing.Size(330, 55);
            this.btnMedicaments.TabIndex = 4;
            this.btnMedicaments.Text = "💊  Stock Médicaments";
            this.btnMedicaments.UseVisualStyleBackColor = false;
            this.btnMedicaments.Click += new System.EventHandler(this.btnMedicaments_Click);
            // 
            // btnStatistiques
            // 
            this.btnStatistiques.BackColor = System.Drawing.Color.Plum;
            this.btnStatistiques.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistiques.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatistiques.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistiques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStatistiques.Location = new System.Drawing.Point(151, 342);
            this.btnStatistiques.Name = "btnStatistiques";
            this.btnStatistiques.Size = new System.Drawing.Size(330, 55);
            this.btnStatistiques.TabIndex = 5;
            this.btnStatistiques.Text = "📈  Statistiques";
            this.btnStatistiques.UseVisualStyleBackColor = false;
            this.btnStatistiques.Click += new System.EventHandler(this.btnStatistiques_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(480, 403);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(140, 38);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnStatistiques);
            this.Controls.Add(this.btnMedicaments);
            this.Controls.Add(this.btnTableauBord);
            this.Controls.Add(this.btnUtilisateurs);
            this.Controls.Add(this.panel);
            this.MinimizeBox = false;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique Fawn - Menu Administrateur";
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBienvenue;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnUtilisateurs;
        private System.Windows.Forms.Button btnTableauBord;
        private System.Windows.Forms.Button btnMedicaments;
        private System.Windows.Forms.Button btnStatistiques;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}
