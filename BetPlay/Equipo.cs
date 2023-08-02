namespace BetPlay
{
    public class Equipo
    {
        public string nombre { get; set; }
        public List<string> propietario { get; set; }

        public List<Jugador> jugadores { get; set; }
        public List<Masajista> masajistas { get; set; }
        public List<Entrenador> entrenadores { get; set; }

        public Equipo(string Nombre){

            this.nombre = Nombre;
            this.propietario = new List<string>();
            this.jugadores = new List<Jugador>();
            this.masajistas = new List<Masajista>();
            this.entrenadores = new List<Entrenador>();
        }
    }
}