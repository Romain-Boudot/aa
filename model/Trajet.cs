using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.model
{
    public class Trajet
    {
        private int id_trajet;
        public int Id_trajet { get => id_trajet; set => id_trajet = value; }

        private string depart;
        public string Depart { get => depart; set => depart = value; }

        private string destination;
        public string Destination { get => destination; set => destination = value; }

        private int duree_s;
        public int Duree_s { get => duree_s; set => duree_s = value; }

        private string dest_info;
        public string Dest_info { get => dest_info; set => dest_info = value; }

        private string duree_info;
        public string Duree_info { get => duree_info; set => duree_info = value; }


        public Trajet(int id_trajet, string depart, string destination, int duree_s, string dest_info, string duree_info)
        {
            this.id_trajet = id_trajet;
            this.depart = depart;
            this.destination = destination;
            this.duree_s = duree_s;
            this.dest_info = dest_info;
            this.duree_info = duree_info;
        }

        public static Trajet GetFromId(int id)
        {
            return new Trajet(id, "depart", "destination", id * 150, "dest info " + id * 150, "" + id * 150 + " minutes");
        }

    }
}
