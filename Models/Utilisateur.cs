using System;

namespace CliniqueVeterinaire.Models
{
    // Héritage : Utilisateur hérite de Personne avec " : Personne "
    // (cours page 9 - Héritage)
    // Classe abstraite aussi : on ne crée pas un "Utilisateur" directement,
    // on crée un Admin, une Secretaire ou un Veterinaire
    public abstract class Utilisateur : Personne
    {
        // === Attributs propres à Utilisateur (cours page 9) ===
        // "une classe fille peut définir de nouveaux champs qui lui ont propres"
        private int id;
        private string login;
        private string motDePasse;
        private string role;

        // Variable statique propre à Utilisateur (cours page 29)
        protected static int nbUtilisateurs = 0;

        // === Constructeur par défaut ===
        // ": base()" appelle le constructeur par défaut de Personne
        // (cours page 36 - Le mot clé base)
        public Utilisateur() : base()
        {
            this.login = "";
            this.motDePasse = "";
            this.role = "";
            nbUtilisateurs++;
        }

        // === Constructeur paramétré ===
        // ": base(...)" appelle le constructeur paramétré de Personne
        // (cours page 38 - Exemple 1)
        public Utilisateur(string nom, string prenom, string telephone,
                           string adresse, string login, string motDePasse, string role)
            : base(nom, prenom, telephone, adresse)
        {
            this.login = login;
            this.motDePasse = motDePasse;
            this.role = role;
            nbUtilisateurs++;
        }

        // === Propriétés get/set (cours pages 6-8) ===
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Login
        {
            get { return login; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    login = value;
            }
        }

        public string MotDePasse
        {
            get { return motDePasse; }
            set
            {
                // Validation : mot de passe d'au moins 4 caractères
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 4)
                    motDePasse = value;
            }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        // === Méthode abstraite (cours page 17) ===
        // Chaque rôle (Admin, Secretaire, Veterinaire) aura son propre menu
        public abstract string AfficherMenu();

        // === Méthode statique (cours page 31) ===
        public static int NombreUtilisateurs()
        {
            return nbUtilisateurs;
        }

        // === Redéfinition de AfficherInfos (cours page 35) ===
        // AfficherInfos était ABSTRAITE dans Personne
        // Ici on l'implémente concrètement
        public override string AfficherInfos()
        {
            return "Utilisateur : " + Nom + " " + Prenom +
                   " | Login : " + login + " | Rôle : " + role;
        }
    }
}