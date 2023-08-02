namespace class1;

    public class Usuario
    {
        public string nombre;
        public string documento;

        public Usuario(string Nombre, string Documento){

            nombre = Nombre;
            documento = Documento;
        }

        string getNombre(){
            return nombre;
        }

        void setNombre (string Nombre){
            nombre = Nombre;
        }

        string getDocumento(){
            return documento;
        }

        void setDocumento (string Documento){
            documento = Documento;
        }
    }





