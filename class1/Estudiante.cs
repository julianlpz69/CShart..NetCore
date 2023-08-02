
namespace class1;

    public class Estudiante : Usuario
    {
        public int idEstudiante;

        public Estudiante(string Nombre, string Documento, int codigo) : base(Nombre, Documento){

            this.idEstudiante = codigo;
            this.documento = Documento;
            this.nombre = Nombre;
        }
    }
