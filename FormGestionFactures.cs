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
    public partial class FormGestionFactures : Form
    {
        public FormGestionFactures()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void facturesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormGestionFactures_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Factures'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.facturesTableAdapter.Fill(this.cliniqueVetDBDataSet.Factures);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                facturesBindingSource.RemoveFilter();
            }
            else
            {
                facturesBindingSource.Filter =
                    "Statut LIKE '%" + recherche + "%' OR " +
                    "Convert(Montant, 'System.String') LIKE '%" + recherche + "%'";
            }
        }
    }
}
