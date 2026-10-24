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
    public partial class FormGestionProprietaires : Form
    {
        public FormGestionProprietaires()
        {
            InitializeComponent();
        }

        private void proprietairesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proprietairesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cliniqueVetDBDataSet);

        }

        private void FormGestionProprietaires_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cliniqueVetDBDataSet.Proprietaires'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.proprietairesTableAdapter.Fill(this.cliniqueVetDBDataSet.Proprietaires);

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            // Récupère ce que l'utilisateur a tapé
            string recherche = txtRecherche.Text.Trim();

            // Si la barre de recherche est vide, on affiche tout
            if (string.IsNullOrEmpty(recherche))
            {
                proprietairesBindingSource.RemoveFilter();
            }
            else
            {
                // Filtre : cherche dans Nom, Prenom, Email, Telephone, Adresse
                proprietairesBindingSource.Filter =
                    "Nom LIKE '%" + recherche + "%' OR " +
                    "Prenom LIKE '%" + recherche + "%' OR " +
                    "Email LIKE '%" + recherche + "%' OR " +
                    "Telephone LIKE '%" + recherche + "%' OR " +
                    "Adresse LIKE '%" + recherche + "%'";
            }
        }
    }
}
