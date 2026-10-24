using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CliniqueVeterinaire.Data
{
    // Classe statique : pas besoin de créer un objet pour l'utiliser
    // (voir cours page 32 - Classe statique)
    public static class DatabaseHelper
    {
        // Attribut statique : existe une seule fois en mémoire
        // (voir cours page 29 - Variables statiques)
        private static string chaineConnexion =
            ConfigurationManager.ConnectionStrings["CliniqueVetDB"].ConnectionString;

        // Méthode statique qui retourne une connexion ouverte
        public static SqlConnection ObtenirConnexion()
        {
            SqlConnection connexion = new SqlConnection(chaineConnexion);
            connexion.Open();
            return connexion;
        }

        // Méthode statique pour tester si la connexion fonctionne
        public static bool TesterConnexion()
        {
            try
            {
                using (SqlConnection connexion = new SqlConnection(chaineConnexion))
                {
                    connexion.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Méthode statique pour exécuter une requête SELECT
        // Retourne un DataTable (tableau de résultats)
        public static DataTable ExecuterRequete(string requete)
        {
            DataTable table = new DataTable();
            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(requete, connexion);
                adapter.Fill(table);
            }
            return table;
        }

        // Méthode statique pour exécuter INSERT/UPDATE/DELETE
        // Retourne le nombre de lignes affectées
        public static int ExecuterCommande(string requete)
        {
            int lignesAffectees = 0;
            using (SqlConnection connexion = new SqlConnection(chaineConnexion))
            {
                connexion.Open();
                SqlCommand commande = new SqlCommand(requete, connexion);
                lignesAffectees = commande.ExecuteNonQuery();
            }
            return lignesAffectees;
        }
    }
}