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
    public partial class FormStockMedicaments : Form
    {
        public FormStockMedicaments()
        {
            InitializeComponent();
        }

        private void medicamentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicamentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormStockMedicaments_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Medicaments'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medicamentsTableAdapter.Fill(this.cliniqueVetDBDataSet.Medicaments);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                medicamentsBindingSource.RemoveFilter();
            }
            else
            {
                medicamentsBindingSource.Filter =
                    "Nom LIKE '%" + recherche + "%' OR " +
                    "Description LIKE '%" + recherche + "%'";
            }
        }
    }
}
