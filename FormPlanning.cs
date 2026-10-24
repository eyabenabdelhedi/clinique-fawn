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
    public partial class FormPlanning : Form
    {
        public FormPlanning()
        {
            InitializeComponent();
        }

        private void rendezVousBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rendezVousBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormPlanning_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.RendezVous'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rendezVousTableAdapter.Fill(this.cliniqueVetDBDataSet.RendezVous);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                rendezVousBindingSource.RemoveFilter();
            }
            else
            {
                rendezVousBindingSource.Filter =
                    "Motif LIKE '%" + recherche + "%' OR " +
                    "Statut LIKE '%" + recherche + "%'";
            }
        }
    }
}
