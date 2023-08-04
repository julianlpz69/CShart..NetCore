namespace Automotriz
{
    public class Cliente
    {
        public long cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long numMovil { get; set; }
        public string gmail { get; set; }
        public string fecha { get; set; }
    

        public Cliente(){}

        public Cliente(long Cedula, string Nombre, string Apellido, long NumMovil, string Gmail, string Fecha){

            cedula = Cedula;
            nombre = Nombre;
            apellido = Apellido;
            numMovil = NumMovil;
            gmail = Gmail;
            fecha = Fecha
        }
    }
}