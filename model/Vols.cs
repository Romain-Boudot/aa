namespace back.model
{
    public class Vol
    {
        private int _id_vol;
        public int Id_vol { get => _id_vol; set => _id_vol = value; }

        private Avion _avion;
        public Avion Avion { get => _avion; set => _avion = value; }

        private Trajet _trajet;
        public Trajet Trajet { get => _trajet; set => _trajet = value; }

        private Employe _pilote;
        public Employe Pilote { get => _pilote; set => _pilote = value; }

        private Employe _copilote;
        public Employe Copilote { get => _copilote; set => _copilote = value; }

        public string Avion_name { get { return _avion.Nom; } }

        public Vol(int a, int b, int c, int d, int e)
        {

        }

        public Vol(int id)
        {
            _id_vol = id;
            _avion = Avion.GetFromId(5);
            _trajet = Trajet.GetFromId(10);
            _pilote = Employe.GetFromId(50);
            _copilote = Employe.GetFromId(100);
        }
    }
}
