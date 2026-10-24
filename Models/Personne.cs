using System;

namespace CliniqueVeterinaire.Models
{
    // Classe abstraite : non instanciable (cours page 18)
    // On ne peut pas faire "new Personne(...)" directement
    public abstract class Personne
    {
        // === Attributs privés (encapsulation - cours page 6) ===
        private string nom;
        private string prenom;
        private string telephone;
        private string adresse;

        // Variable statique : compte le nombre de personnes créées
        // (cours page 29 - Variables statiques)
        protected static int nbPersonnes = 0;

        // === Constructeur par défaut (cours page 23) ===
        public Personne()
        {
            this.nom = "";
            this.prenom = "";
            this.telephone = "";
            this.adresse = "";
            nbPersonnes++;
        }

        // === Constructeur paramétré ===
        // Le mot-clé "this" lève l'ambiguïté (cours page 28)
        public Personne(string nom, string prenom, string telephone, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.adresse = adresse;
            nbPersonnes++;
        }

        // === Propriétés get/set (cours pages 6-8) ===
        public string Nom
        {
            get { return nom; }
            set
            {
                // Validation : on refuse un nom vide
                if (!string.IsNullOrWhiteSpace(value))
                    nom = value;
            }
        }

        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    prenom = value;
            }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        // === Méthode abstraite (cours page 17) ===
        // Pas de corps → chaque classe fille DOIT la redéfinir
        public abstract string AfficherInfos();

        // === Méthode statique (cours page 31) ===
        // S'appelle via Personne.NombrePersonnes() sans créer d'objet
        public static int NombrePersonnes()
        {
            return nbPersonnes;
        }

        // === Redéfinition de ToString (cours page 35) ===
        // ToString existe déjà dans la classe Object (cours page 9)
        public override string ToString()
        {
            return nom + " " + prenom + " - Tél: " + telephone;
        }
    }
}