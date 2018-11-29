using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.model
{
    public class Moteur
    {
        private int id_moteur;
        public int Id_moteur { get => id_moteur; set => id_moteur = value; }

        private string nom;
        public string Nom { get => nom; set => nom = value; }


        public Moteur(int id_moteur, string nom)
        {
            this.id_moteur = id_moteur;
            this.nom = nom;
        }
    }
}
