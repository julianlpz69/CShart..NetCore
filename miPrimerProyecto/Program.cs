using System;

public class Program
{
    public static void Main(string[] args)
    {


        string? palabra;
        List<String> Dinosaurios = new List<String>();
        string[] Dinos = {
                            "Brachiosaurios",
                            "Amargasarus",
                            "Mamenchinsaurios"
                            };

Dinosaurios.AddRange(Dinos);
Console.WriteLine("Ingrese el nombre del dinosaurio a buscar");
palabra = Console.ReadLine();
Console.WriteLine(Dinosaurios.Exists(item => item.Equals(palabra)) ? "Se encpntro el dinoaurio" : "No se encontro al dinosaurio");        


        

        // List<string> Materias = new List<string>();

        // Materias.Add("Calculo");
        // Materias.Add("Español");
        // Materias.Add("Dibujo Tecnico");
        // Materias.Add("Ingles");

        // Console.WriteLine("Total de elementos de la lista {0}",Materias.Count());

    }
}