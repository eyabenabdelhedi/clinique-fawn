using System;

namespace CliniqueVeterinaire.Models
{
    // Admin hérite de Utilisateur (cours page 9)
    public class Admin : Utilisateur
    {
        // === Constructeur par défaut ===
        // base() appelle le constructeur par défaut de Utilisateur
        // (cours page 38)
        public Admin() : base()
        {
        }

        // === Constructeur paramétré ===
        // On passe "Admin" comme rôle au constructeur de Utilisateur
        public Admin(string nom, string prenom, string telephone,
                     string adresse, string login, string motDePasse)
            : base(nom, prenom, telephone, adresse, login, motDePasse, "Admin")
        {
        }

        // === Redéfinition de la méthode abstraite AfficherMenu ===
        // (cours page 35 - polymorphisme dynamique)
        public override string AfficherMenu()
        {
            return "Menu Administrateur : " +
                   "Gestion Utilisateurs | Tableau de bord | " +
                   "Statistiques | Stock Médicaments";
        }

        // === Redéfinition de ToString avec appel à base ===
        // (cours page 37 - Le mot clé base)
        public override string ToString()
        {
            return "[ADMIN] " + base.ToString();
        }
    }
}
