using Jsons;

internal class Program
{
    private static void Main(string[] args)
    {   

        ConvertirJson nuevo = new();
        Persona persona = new("Julianssss",1922,"Snowmanssss");   
        nuevo.Serializar(persona);
    }
}