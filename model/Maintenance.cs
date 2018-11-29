using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Maintenance
    {
        private int id_maintenance;
        public int Id_maintenance { get => id_maintenance; set => id_maintenance = value; }

        private int id_avion;
        public int Id_avion { get => id_avion; set => id_avion = value; }

        private string reason;
        public string Reason { get => reason; set => reason = value; }


        public Maintenance(int id_maintenance, int id_avion, string reason)
        {
            this.id_maintenance = id_maintenance;
            this.id_avion = id_avion;
            this.reason = reason;
        }
    }
}