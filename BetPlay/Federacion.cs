namespace BetPlay
{
    public class Federacion
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public string ciudadOrigen { get; set; }
        public long id { get; set; }
        
        public Federacion (string Nombre, int Edad, string CiudadOrigen, long Id){
            this.nombre = Nombre;
            this.edad = Edad;
            this.ciudadOrigen = CiudadOrigen;
            this.id = Id;
        }

        
    }
}