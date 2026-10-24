using System;

namespace CliniqueVeterinaire.Models
{
    public class Veterinaire : Utilisateur
    {
        // === Nouvel attribut propre à Veterinaire (cours page 9) ===
        // "Une classe fille peut définir de nouveaux champs qui lui ont propres"
        private string specialite;

        public Veterinaire() : base()
        {
            this.specialite = "";
        }

        // Constructeur avec un paramètre en PLUS : specialite
        public Veterinaire(string nom, string prenom, string telephone,
                           string adresse, string login, string motDePasse,
                           string specialite)
            : base(nom, prenom, telephone, adresse, login, motDePasse, "Veterinaire")
        {
            this.specialite = specialite;
        }

        // Propriété get/set pour specialite (cours page 6)
        public string Specialite
        {
            get { return specialite; }
            set { specialite = value; }
        }

        public override string AfficherMenu()
        {
            return "Menu Vétérinaire : " +
                   "Mon planning | Consultations | Vaccinations | Historique animaux";
        }

        // Redéfinition de ToString qui AJOUTE la spécialité
        // et appelle base.ToString() pour garder l'info de la classe mère
        // (cours page 37)
        public override string ToString()
        {
            return "[VETO - " + specialite + "] " + base.ToString();
        }
    }
}