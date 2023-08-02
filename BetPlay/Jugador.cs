namespace BetPlay
{
    public class Jugador : Federacion
    {
        public string dorsal { get; set; }
        public string posicion { get; set; }

        public Jugador(string Nombre, int Edad, string CiudadOrigen, long Id, string Dorsal,string Posicion) : base(Nombre,Edad,CiudadOrigen,Id){
            this.dorsal = Dorsal;
            this.posicion = Posicion;
        }
    }
}