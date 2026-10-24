using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliniqueVeterinaire
{
    public partial class FormVaccinations : Form
    {
        public FormVaccinations()
        {
            InitializeComponent();
        }

        private void vaccinationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vaccinationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormVaccinations_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Vaccinations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vaccinationsTableAdapter.Fill(this.cliniqueVetDBDataSet.Vaccinations);

        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                vaccinationsBindingSource.RemoveFilter();
            }
            else
            {
                vaccinationsBindingSource.Filter =
                    "NomVaccin LIKE '%" + recherche + "%'";
            }
        }
    }
}
