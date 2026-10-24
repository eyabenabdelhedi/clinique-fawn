using System;
using System.Windows.Forms;
using CliniqueVeterinaire.Models;

namespace CliniqueVeterinaire
{
    public partial class FormMenuSecretaire : Form
    {
        private Secretaire _secretaire;

        public FormMenuSecretaire(Secretaire secretaire)
        {
            InitializeComponent();
            _secretaire = secretaire;
            lblBienvenue.Text = "Bienvenue Secrétaire " + _secretaire.Prenom + " " + _secretaire.Nom;
        }

        private void FormMenuSecretaire_Load(object sender, EventArgs e)
        {

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Êtes-vous sûr de vouloir vous déconnecter ?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnProprietaires_Click(object sender, EventArgs e)
        {
            FormGestionProprietaires formProprietaires = new FormGestionProprietaires();
            formProprietaires.ShowDialog();
        }

        private void btnAnimaux_Click(object sender, EventArgs e)
        {
            FormGestionAnimaux formAnimaux = new FormGestionAnimaux();
            formAnimaux.ShowDialog();
        }

        private void btnRendezVous_Click(object sender, EventArgs e)
        {
            FormGestionRendezVous formRendezVous = new FormGestionRendezVous();
            formRendezVous.ShowDialog();
        }

        private void btnFactures_Click(object sender, EventArgs e)
        {
            FormGestionFactures formFactures = new FormGestionFactures();
            formFactures.ShowDialog();
        }
    }
}
