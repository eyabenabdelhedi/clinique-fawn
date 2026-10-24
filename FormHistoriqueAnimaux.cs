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
    public partial class FormHistoriqueAnimaux : Form
    {
        public FormHistoriqueAnimaux()
        {
            InitializeComponent();
        }

        private void consultationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormHistoriqueAnimaux_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Consultations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.consultationsTableAdapter.Fill(this.cliniqueVetDBDataSet.Consultations);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                consultationsBindingSource.RemoveFilter();
            }
            else
            {
                consultationsBindingSource.Filter =
                    "Diagnostic LIKE '%" + recherche + "%' OR " +
                    "Traitement LIKE '%" + recherche + "%' OR " +
                    "Remarques LIKE '%" + recherche + "%'";
            }
        }
    }
}
