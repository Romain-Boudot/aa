using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back.model
{
    public class Type
    {
        private int id_type;
        public int Id_type { get => id_type; set => id_type = value; }

        private string nom;
        public string Nom { get => nom; set => nom = value; }

        public Type(int id_type, string type)
        {
            this.id_type = id_type;
            this.Nom = type;
        }
    }
}
