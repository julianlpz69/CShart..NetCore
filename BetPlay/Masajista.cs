namespace BetPlay
{
    public class Masajista : Federacion
    {
        public string titulacion { get; set; }
        public int añosExp { get; set; }

        public Masajista(string Nombre, int Edad, string CiudadOrigen, long Id, string Titulacion,int AñosExp) : base(Nombre,Edad,CiudadOrigen,Id){
            this.titulacion = Titulacion;
            this.añosExp = AñosExp;
        }
    }
}