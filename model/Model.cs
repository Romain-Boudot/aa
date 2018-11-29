using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.model
{
    class Model
    {
        private int id_modele;
        public int Id_modele { get => id_modele; set => id_modele = value; }

        private string nom;
        public string Nom { get => nom; set => nom = value; }

        private int nb_passager;
        public int Nb_passager { get => nb_passager; set => nb_passager = value; }

        private int eco;
        public int Eco { get => eco; set => eco = value; }

        private int prem_eco;
        public int Prem_eco { get => prem_eco; set => prem_eco = value; }

        private int business;
        public int Business { get => business; set => business = value; }

        private int premiere;
        public int Premiere { get => premiere; set => premiere = value; }


        public Model(int id_modele, string nom, int nb_passager, int eco, int prem_eco, int business, int premiere)
        {
            this.id_modele = id_modele;
            this.nom = nom;
            this.nb_passager = nb_passager;
            this.eco = eco;
            this.prem_eco = prem_eco;
            this.business = business;
            this.premiere = premiere;
        }
    }
}
