// Ejemplo_06_02a.cs
// Primer ejemplo de clases
// Introducción a C#, por Nacho Cabanes

using System;

    class Usuario
{
    // Propiedades de la clase Usuario
    public string Nombre;
    public string Edad ;
    public string Hobbies;

    // Constructor de la clase Usuario
    public Usuario(string nombre, string edad, string hobbies)
    {
        Nombre = nombre;
        Edad = edad;
        Hobbies = hobbies;
    }
}



 // Final de la clase Puerta   


public class Ejemplo_06_02a
{

    public static void Main()
    {

        Usuario usuario = new Usuario("nombressssss","edadsssssssss","hobbiessssssssssss");

        usuario.Nombre = "ssss";
        Console.WriteLine($"{usuario.Nombre}");

}}
