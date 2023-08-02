namespace BetPlay
{
    public class Entrenador : Federacion
    {
        public long codigoFederacion { get; set; }
        public string especialidad { get; set; }

        public Entrenador(string Nombre, int Edad, string CiudadOrigen, long Id, long CodigoFederacion, string Especialidad) : base(Nombre,Edad,CiudadOrigen,Id){
            this.codigoFederacion = CodigoFederacion;
            this.especialidad = Especialidad;
        }
}
}