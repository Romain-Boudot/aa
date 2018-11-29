namespace back.model
{
    public class Vol
    {
        private int id_vol;
        public int Id_vol { get => id_vol; set => id_vol = value; }

        private Avion avion;
        public Avion Avion { get => avion; set => avion = value; }

        private Trajet trajet;
        public Trajet Trajet { get => trajet; set => trajet = value; }

        private Employe pilote;
        public Employe Pilote { get => pilote; set => pilote = value; }

        private Employe copilote;
        public Employe Copilote { get => copilote; set => copilote = value; }

        public string Avion_name { get { return avion.Nom; } }

        public Vol(int id)
        {
            id_vol = id;
            avion = Avion.GetFromId(0);
            trajet = id_trajet;
            this.id_pilote = id_pilote;
            this.id_copilote = id_copilote;
        }
    }
}
