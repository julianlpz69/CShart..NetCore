namespace class1
{
    public class Profesor : Usuario
    {
        public int idProfesor;
        
        public Profesor (string Nombre, string Documento, int codigo) : base(Nombre,Documento){
            this.nombre = Nombre;
        }

    }
}