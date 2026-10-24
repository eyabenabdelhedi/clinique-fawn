using System;
using System.Windows.Forms;
using CliniqueVeterinaire.Models;

namespace CliniqueVeterinaire
{
    public partial class FormMenuAdmin : Form
    {
        private Admin _admin;

        public FormMenuAdmin(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
            lblBienvenue.Text = "Bienvenue Admin " + _admin.Prenom + " " + _admin.Nom;
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lblBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            // Demander confirmation
            DialogResult result = MessageBox.Show(
                "Êtes-vous sûr de vouloir vous déconnecter ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Ferme le menu → retourne au Login
            }
        }

        private void btnMedicaments_Click(object sender, EventArgs e)
        {
            FormStockMedicaments formMedicaments = new FormStockMedicaments();
            formMedicaments.ShowDialog();
        }

        private void btnUtilisateurs_Click(object sender, EventArgs e)
        {
            FormGestionUtilisateurs formUtilisateurs = new FormGestionUtilisateurs();
            formUtilisateurs.ShowDialog();
        }

        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            FormTableauBord formTableauBord = new FormTableauBord();
            formTableauBord.ShowDialog();
        }

        private void btnStatistiques_Click(object sender, EventArgs e)
        {
            FormTableauBord formTableauBord = new FormTableauBord();
            formTableauBord.ShowDialog();
        }
    }
}
