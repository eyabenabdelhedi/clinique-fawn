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
    public partial class FormGestionUtilisateurs : Form
    {
        public FormGestionUtilisateurs()
        {
            InitializeComponent();
        }

        private void utilisateursBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.utilisateursBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormGestionUtilisateurs_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Utilisateurs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.utilisateursTableAdapter.Fill(this.cliniqueVetDBDataSet.Utilisateurs);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();

            if (string.IsNullOrEmpty(recherche))
            {
                utilisateursBindingSource.RemoveFilter();
            }
            else
            {
                utilisateursBindingSource.Filter =
                    "Nom LIKE '%" + recherche + "%' OR " +
                    "Prenom LIKE '%" + recherche + "%' OR " +
                    "Login LIKE '%" + recherche + "%' OR " +
                    "Role LIKE '%" + recherche + "%' OR " +
                    "Email LIKE '%" + recherche + "%'";
            }
        }
    }
}
