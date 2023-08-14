namespace Jsons
{
    public class Persona
    {
        public string nombre {get ; set ;}
        public int edad {get ; set ;}
        public string musica {get ; set ;}

        public Persona(string Nombre, int Edad , string Musica){
            nombre = Nombre;
            edad = Edad ;
            musica = Musica; 
        }
    }
}