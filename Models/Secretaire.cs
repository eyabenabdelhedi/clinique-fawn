using System;

namespace CliniqueVeterinaire.Models
{
    public class Secretaire : Utilisateur
    {
        public Secretaire() : base()
        {
        }

        public Secretaire(string nom, string prenom, string telephone,
                          string adresse, string login, string motDePasse)
            : base(nom, prenom, telephone, adresse, login, motDePasse, "Secretaire")
        {
        }

        public override string AfficherMenu()
        {
            return "Menu Secrétaire : " +
                   "Propriétaires | Animaux | Rendez-vous | Factures";
        }

        public override string ToString()
        {
            return "[SECRETAIRE] " + base.ToString();
        }
    }
}