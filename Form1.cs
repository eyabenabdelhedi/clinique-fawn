using CliniqueVeterinaire.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using CliniqueVeterinaire.Models;

namespace CliniqueVeterinaire
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblMotDePasse_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            // === 1. Récupérer les valeurs saisies ===
            string login = txtLogin.Text.Trim();
            string motDePasse = txtMotDePasse.Text.Trim();

            // === 2. Vérifier que les champs ne sont pas vides ===
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.",
                    "Champs manquants",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // === 3. Construire et exécuter la requête SQL ===
                string requete = "SELECT * FROM Utilisateurs " +
                                 "WHERE Login = '" + login + "' " +
                                 "AND MotDePasse = '" + motDePasse + "'";

                DataTable resultat = DatabaseHelper.ExecuterRequete(requete);

                // === 4. Vérifier si un utilisateur a été trouvé ===
                if (resultat.Rows.Count == 0)
                {
                    MessageBox.Show("Login ou mot de passe incorrect.",
                        "Erreur de connexion",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // === 5. Récupérer les données de l'utilisateur trouvé ===
                DataRow ligne = resultat.Rows[0];
                string nom = ligne["Nom"].ToString();
                string prenom = ligne["Prenom"].ToString();
                string telephone = ligne["Telephone"] != DBNull.Value ? ligne["Telephone"].ToString() : "";
                string adresse = ligne["Adresse"] != DBNull.Value ? ligne["Adresse"].ToString() : "";
                string role = ligne["Role"].ToString();

                // === 6. POLYMORPHISME DYNAMIQUE ! (cours page 35) ===
                Utilisateur utilisateurConnecte = null;

                if (role == "Admin")
                {
                    utilisateurConnecte = new Admin(nom, prenom, telephone, adresse, login, motDePasse);
                }
                else if (role == "Secretaire")
                {
                    utilisateurConnecte = new Secretaire(nom, prenom, telephone, adresse, login, motDePasse);
                }
                else if (role == "Veterinaire")
                {
                    string specialite = ligne["Specialite"] != DBNull.Value ? ligne["Specialite"].ToString() : "";
                    utilisateurConnecte = new Veterinaire(nom, prenom, telephone, adresse, login, motDePasse, specialite);
                }

                // === 7. Vérifier que l'objet a bien été créé ===
                if (utilisateurConnecte == null)
                {
                    MessageBox.Show("Rôle inconnu : " + role,
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // === 8. Récupérer l'ID et l'affecter à l'objet ===
                utilisateurConnecte.Id = Convert.ToInt32(ligne["IdUtilisateur"]);

                // === 9. Redirection vers le bon menu (sans MessageBox) ===
                // === 9. Redirection vers le bon menu (sans MessageBox) ===
                Form menuForm = null;

                if (utilisateurConnecte is Admin admin)
                {
                    menuForm = new FormMenuAdmin(admin);
                }
                else if (utilisateurConnecte is Secretaire secretaire)
                {
                    menuForm = new FormMenuSecretaire(secretaire);
                }
                else if (utilisateurConnecte is Veterinaire veterinaire)
                {
                    menuForm = new FormMenuVeterinaire(veterinaire);
                }

                // === 10. Cacher le Login et afficher le Menu ===
                if (menuForm != null)
                {
                    this.Hide();
                    menuForm.ShowDialog();
                    this.Show(); // Réafficher la connexion à la fermeture du menu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}