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
    public partial class FormGestionAnimaux : Form
    {
        public FormGestionAnimaux()
        {
            InitializeComponent();
        }

        private void animauxBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animauxBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormGestionAnimaux_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Animaux'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.animauxTableAdapter.Fill(this.cliniqueVetDBDataSet.Animaux);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                animauxBindingSource.RemoveFilter();
            }
            else
            {
                animauxBindingSource.Filter =
                    "Nom LIKE '%" + recherche + "%' OR " +
                    "Espece LIKE '%" + recherche + "%' OR " +
                    "Race LIKE '%" + recherche + "%' OR " +
                    "Sexe LIKE '%" + recherche + "%'";
            }
        }
    }
}
