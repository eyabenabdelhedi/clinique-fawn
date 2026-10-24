
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CliniqueVeterinaire.Data;

namespace CliniqueVeterinaire
{
    public partial class FormTableauBord : Form
    {
        public FormTableauBord()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void FormTableauBord_Load(object sender, EventArgs e)
        {
            ChargerStatistiques();
        }

        private void ChargerStatistiques()
        {
            try
            {
                // Compter les propriétaires
                DataTable dtProp = DatabaseHelper.ExecuterRequete("SELECT COUNT(*) AS Nb FROM Proprietaires");
                lblNbProprietaires.Text = dtProp.Rows[0]["Nb"].ToString();

                // Compter les animaux
                DataTable dtAnim = DatabaseHelper.ExecuterRequete("SELECT COUNT(*) AS Nb FROM Animaux");
                lblNbAnimaux.Text = dtAnim.Rows[0]["Nb"].ToString();

                // Compter les rendez-vous
                DataTable dtRDV = DatabaseHelper.ExecuterRequete("SELECT COUNT(*) AS Nb FROM RendezVous");
                lblNbRDV.Text = dtRDV.Rows[0]["Nb"].ToString();

                // Compter les consultations
                DataTable dtCons = DatabaseHelper.ExecuterRequete("SELECT COUNT(*) AS Nb FROM Consultations");
                lblNbConsultations.Text = dtCons.Rows[0]["Nb"].ToString();

                // Compter les vaccinations
                DataTable dtVacc = DatabaseHelper.ExecuterRequete("SELECT COUNT(*) AS Nb FROM Vaccinations");
                lblNbVaccinations.Text = dtVacc.Rows[0]["Nb"].ToString();

                // Compter les médicaments
                DataTable dtMed = DatabaseHelper.ExecuterRequete("SELECT COUNT(*) AS Nb FROM Medicaments");
                lblNbMedicaments.Text = dtMed.Rows[0]["Nb"].ToString();

                // Calculer les revenus (somme des factures payées)
                DataTable dtRev = DatabaseHelper.ExecuterRequete(
                    "SELECT ISNULL(SUM(MontantTotal), 0) AS Total FROM Factures WHERE Statut = 'Payee'");
                decimal total = Convert.ToDecimal(dtRev.Rows[0]["Total"]);
                lblRevenus.Text = total.ToString("F2");

                // Compter factures payées vs impayées
                DataTable dtPayee = DatabaseHelper.ExecuterRequete(
                    "SELECT COUNT(*) AS Nb FROM Factures WHERE Statut = 'Payee'");
                DataTable dtImpayee = DatabaseHelper.ExecuterRequete(
                    "SELECT COUNT(*) AS Nb FROM Factures WHERE Statut = 'Impayee'");
                lblFactures.Text = dtPayee.Rows[0]["Nb"] + " / " + dtImpayee.Rows[0]["Nb"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            ChargerStatistiques();
            MessageBox.Show("Statistiques actualisées !",
                "Tableau de Bord",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FormTableauBord_Load_1(object sender, EventArgs e)
        {

        }
    }
}



