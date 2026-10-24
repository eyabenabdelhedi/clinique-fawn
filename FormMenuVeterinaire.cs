using System;
using System.Windows.Forms;
using CliniqueVeterinaire.Models;

namespace CliniqueVeterinaire
{
    public partial class FormMenuVeterinaire : Form
    {
        private Veterinaire _veterinaire;

        public FormMenuVeterinaire(Veterinaire veterinaire)
        {
            InitializeComponent();
            _veterinaire = veterinaire;
            lblBienvenue.Text = "Bienvenue Dr. " + _veterinaire.Prenom + " " +
                                _veterinaire.Nom + " - " + _veterinaire.Specialite;
        }

        private void FormMenuVeterinaire_Load(object sender, EventArgs e)
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

        private void btnConsultations_Click(object sender, EventArgs e)
        {
            FormConsultations formConsultations = new FormConsultations();
            formConsultations.ShowDialog();
        }

        private void btnVaccinations_Click(object sender, EventArgs e)
        {
            FormVaccinations formVaccinations = new FormVaccinations();
            formVaccinations.ShowDialog();
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            FormPlanning formPlanning = new FormPlanning();
            formPlanning.ShowDialog();
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            FormHistoriqueAnimaux formHistorique = new FormHistoriqueAnimaux();
            formHistorique.ShowDialog();
        }
    }
}
