using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.model
{
    public class Employe
    {
        private int id_employe;
        public int Id_employe { get => id_employe; set => id_employe = value; }

        private string nom;
        public string Nom { get => nom; set => nom = value; }

        private string prenom;
        public string Prenom { get => prenom; set => prenom = value; }

        private float salaire;
        public float Salaire { get => salaire; set => salaire = value; }

        private bool civilite;
        public bool Civilite { get => civilite; set => civilite = value; }

        private string date_naissance;
        public string Date_naissance { get => date_naissance; set => date_naissance = value; }

        private string formation;
        public string Formation { get => formation; set => formation = value; }

        private string fonction;
        public string Fonction { get => fonction; set => formation = value; }


        private Employe(int id_employe, string nom, string prenom, float salaire, bool civilite, string date_naissance, string formation, string fonction)
        {
            this.id_employe = id_employe;
            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;
            this.civilite = civilite;
            this.date_naissance = date_naissance;
            this.formation = formation;
            this.fonction = fonction;
        }

        public static Employe GetFromId(int id)
        {
            return new Employe(id, "nom", "prenom", (float) 1500.50, true, "date de niassance", "pilote/copilote", "pilote/copilote");
        }

    }
}
