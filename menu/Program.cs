using System;
using System.Collections;
using System.Collections.Generic;




class Program {
    
    static List<long> numerosTelefonicos = new List<long>();
    static List<long> numerosTelefonicosImportantes = new List<long>();


    static void Main() {


        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    mostrarTelefonos();
                    break;
                case 2:
                    agregarTelefono();
                    ;
                    break;
                case 3:
                    agregarTelefonoImportante();
                    break;
                case 4:
                    eliminarTelefono();
                    break;
                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }

    static void MostrarMenu() {
        Console.WriteLine("\nMenú de opciones:");
        Console.WriteLine("\n1. Mostrar Contactos Agregados");
        Console.WriteLine("2. Agregar Contactos");
        Console.WriteLine("3. Indicar Contacto Importante");
        Console.WriteLine("4. Eliminar Contacto");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion() {
        Console.Write("\nElige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }


    static void agregarTelefono() {
        Console.Write("\nIngresa el numero de celular: ");
        long.TryParse(Console.ReadLine(),out long numero);
        Program.numerosTelefonicos.Add(numero);
    }

    static void mostrarTelefonos(){
        foreach (var elemento in Program.numerosTelefonicos)
{      
    if(Program.numerosTelefonicosImportantes.Contains(elemento)==true){
        Console.WriteLine("\n-----------------------");
        Console.WriteLine($"{elemento} Importanteee");
    }
    else{
        Console.WriteLine("\n-----------------------");
        Console.WriteLine(elemento);}
}
    }

    static void eliminarTelefono(){
        Console.Write("\nIngresa el numero de celular número para Eliminar: ");
        long.TryParse(Console.ReadLine(),out long numero);
        if(Program.numerosTelefonicos.Contains(numero) == true){
            Program.numerosTelefonicos.Remove(numero);
            Console.Write("\nTelefono Eliminado Exitosamente");
        }
        else{
            Console.Write("\nNumero de Telefono No Registrado");
        }
    }


        static void agregarTelefonoImportante() {
        Console.Write("\nIngresa el numero de celular: ");
        long.TryParse(Console.ReadLine(),out long numero);
        Program.numerosTelefonicosImportantes.Add(numero);
    }


}