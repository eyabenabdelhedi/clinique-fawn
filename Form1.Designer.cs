namespace CliniqueVeterinaire
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.Titre);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(650, 110);
            this.panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(115, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connexion à votre espace professionnel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.Color.Transparent;
            this.Titre.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.Color.Crimson;
            this.Titre.Location = new System.Drawing.Point(130, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(379, 50);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "🐾 Clinique Fawn🐾";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(99, 138);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(202, 28);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Nom d\'untilisateur :";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lblMotDePasse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.Location = new System.Drawing.Point(99, 238);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(149, 28);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe :";
            this.lblMotDePasse.Click += new System.EventHandler(this.lblMotDePasse_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(104, 183);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(405, 27);
            this.txtLogin.TabIndex = 3;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(104, 285);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(405, 27);
            this.txtMotDePasse.TabIndex = 4;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // btnConnecter
            // 
            this.btnConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(223)))), ((int)(((byte)(185)))));
            this.btnConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnecter.FlatAppearance.BorderSize = 0;
            this.btnConnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnecter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnecter.Location = new System.Drawing.Point(104, 355);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(165, 42);
            this.btnConnecter.TabIndex = 5;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnnuler.Location = new System.Drawing.Point(344, 355);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(165, 42);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FormLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique Fawn-Connexion";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

