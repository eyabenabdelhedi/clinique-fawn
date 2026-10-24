using System;

namespace CliniqueVeterinaire.Models
{
    // Proprietaire hérite de Personne (cours page 9)
    // Classe NON abstraite : on peut créer des objets directement
    public class Proprietaire : Personne
    {
        // === Attributs propres à Proprietaire ===
        private int id;
        private string email;

        // Variable statique (cours page 29)
        protected static int nbProprietaires = 0;

        // === Constructeur par défaut ===
        public Proprietaire() : base()
        {
            this.email = "";
            nbProprietaires++;
        }

        // === Constructeur paramétré ===
        // base(...) appelle le constructeur de Personne (cours page 38)
        public Proprietaire(string nom, string prenom, string telephone,
                            string adresse, string email)
            : base(nom, prenom, telephone, adresse)
        {
            this.email = email;
            nbProprietaires++;
        }

        // === Propriétés get/set (cours pages 6-8) ===
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // === Méthode statique (cours page 31) ===
        public static int NombreProprietaires()
        {
            return nbProprietaires;
        }

        // === Redéfinition de AfficherInfos ===
        // Méthode abstraite héritée de Personne (cours pages 17, 35)
        public override string AfficherInfos()
        {
            return "Propriétaire : " + Nom + " " + Prenom +
                   " | Email : " + email + " | Tél : " + Telephone;
        }

        // Redéfinition de ToString (cours page 35)
        public override string ToString()
        {
            return Nom + " " + Prenom + " (" + email + ")";
        }
    }
}
