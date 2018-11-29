using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.model
{
    public class Avion
    {
        private int id_avion;
        public int Id_avion { get => id_avion; set => id_avion = value; }

        private bool dispo;
        public bool Dispo { get => dispo; set => dispo = value; }

        private string nom;
        public string Nom { get => nom; set => nom = value; }

        private Moteur moteur;
        public Moteur Moteur { get => moteur; }

        private Type type;
        public Type Type { get => type; set => type = value; }

        private int capacite;
        public int Capacite { get => capacite; set => capacite = value; }


        private Avion(int id_avion, bool dispo, string nom, int moteur, int type, int capacite)
        {
            this.id_avion = id_avion;
            this.dispo = dispo;
            this.nom = nom;
            //this.moteur = moteur;
            //this.type = type;
            this.capacite = capacite;
        }

        //public static Avion GetFromId(int id)
        //{
        //    return new Avion(0, false, "test", 0, 0, 0);
        //}

        public static List<Avion> GetAvions()
        {
            return new List<Avion>();
        }

    }
}
