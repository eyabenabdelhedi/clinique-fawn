using System;

namespace CliniqueVeterinaire.Models
{
    // Classe simple (pas d'héritage)
    public class Animal
    {
        // === Attributs privés (encapsulation - cours page 6) ===
        private int id;
        private string nom;
        private string espece;
        private string race;
        private DateTime dateNaissance;
        private string sexe;
        private int idProprietaire;

        // Variable statique (cours page 29)
        private static int nbAnimaux = 0;

        // === Constructeur par défaut ===
        public Animal()
        {
            this.nom = "";
            this.espece = "";
            this.race = "";
            this.dateNaissance = DateTime.Now;
            this.sexe = "";
            nbAnimaux++;
        }

        // === Constructeur paramétré ===
        public Animal(string nom, string espece, string race,
                      DateTime dateNaissance, string sexe, int idProprietaire)
        {
            this.nom = nom;
            this.espece = espece;
            this.race = race;
            this.dateNaissance = dateNaissance;
            this.sexe = sexe;
            this.idProprietaire = idProprietaire;
            nbAnimaux++;
        }

        // === Propriétés get/set (cours pages 6-8) ===
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nom = value;
            }
        }

        public string Espece
        {
            get { return espece; }
            set { espece = value; }
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public int IdProprietaire
        {
            get { return idProprietaire; }
            set { idProprietaire = value; }
        }

        // === Méthode statique (cours page 31) ===
        public static int NombreAnimaux()
        {
            return nbAnimaux;
        }

        // === Méthode d'instance : calcule l'âge de l'animal ===
        public int CalculerAge()
        {
            int age = DateTime.Now.Year - dateNaissance.Year;
            if (DateTime.Now.DayOfYear < dateNaissance.DayOfYear)
                age--;
            return age;
        }

        // === Redéfinition de ToString ===
        public override string ToString()
        {
            return nom + " (" + espece + " - " + race + ", " + CalculerAge() + " ans)";
        }
    }
}