using System.Reflection.PortableExecutable;
using System.Text.Json;

namespace Jsons
{
    public class ConvertirJson
    {
        public string nombre = "objetos.json";

        public  Dictionary<int,Persona> productos = new();

        public  string Nombre {get => nombre; set => nombre =value;} 
        public  Dictionary<int,Persona> Productos {get => productos; set => productos =value;}


        public void Serializar(Persona persona){

            string miJson = JsonSerializer.Serialize(persona);
            File.WriteAllText(nombre,miJson);
        }

        public void DesSerializar(){
            
        }


    }
}