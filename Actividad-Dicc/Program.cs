using System;
using System.Collections;
using System.Collections.Generic;
















class Program {
    

    static Dictionary<string,Usuario> usuarios = new Dictionary<string,Usuario>();


    class Usuario
{
    // Propiedades de la clase Usuario
    public string Nombre { get; set; }
    public string Edad { get; set; }
    public List<string> Hobbies { get; set; }

    // Constructor de la clase Usuario
    public Usuario(string nombre, string edad, List<string> hobbies)
    {
        Nombre = nombre;
        Edad = edad;
        Hobbies = hobbies;
    }
}



    static void Main() {


        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    agregarUsuario();
                    break;
                case 2:
                mostrarUsuario()

                    ;
                    break;
                case 3:
                mostrarUsuarios();
                break;
                case 4:
                eliminarUsario();
                    break;
                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;
       }} while (opcion != 5);
    }

    static void MostrarMenu() {
        Console.WriteLine("\nMenú de opciones:");
        Console.WriteLine("\n1. Agregar Usuario");
        Console.WriteLine("2. Mostrar Usuario");
        Console.WriteLine("3. Mostrar Todos los Usuarios");
        Console.WriteLine("4. Eliminar Usuario");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion() {
        Console.Write("\nElige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }



    static void agregarUsuario(){

        Console.Write("\nIngresa el numero de identificacion del usuario: ");
        string? numero = Console.ReadLine();
        Console.Write("\nIngresa el nombre del usuario: ");
        string? nombre = Console.ReadLine();
        Console.Write("\nIngresa la edad del usuario: ");
        string? edad = Console.ReadLine();

        List<string> hobbies = new List<string>();
        string? hobby;
         do{
            Console.Write("Ingresa un hobbie (o escribe 'fin' para terminar): ");
            hobby = Console.ReadLine();

            if (hobby != "fin")
            {
                hobbies.Add(hobby);
            }
} while (hobby.ToLower() != "fin");

        Usuario usuario = new Usuario(nombre,edad,hobbies);


        Program.usuarios.Add($"{numero}", usuario);

    }


    static void mostrarUsuarios(){



        Console.WriteLine($"\nIdentificacion------Nombre-------------Edad-----------");
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"\n-----{usuario.Key}---------{usuario.Value.Nombre}-------------{usuario.Value.Edad}---");
            Console.WriteLine($"\n-----Hobbies---------");

            foreach (string hobby in usuario.Value.Hobbies)
        {
            Console.WriteLine($"- {hobby}");
        }


        }
}


static void mostrarUsuario(){



        Console.Write("Ingresa el número de identificación del usuario: ");
        string? numeroUsuario = Console.ReadLine();

        // Verificar si el usuario existe en el diccionario
        if (usuarios.TryGetValue(numeroUsuario, out Usuario usuarioEncontrado))
        {
            // Imprimir los datos del usuario encontrado
            Console.WriteLine($"Datos del usuario con número de identificación {numeroUsuario}:");
            Console.WriteLine($"Nombre: {usuarioEncontrado.Nombre}");
            Console.WriteLine($"Edad: {usuarioEncontrado.Edad}");
            Console.WriteLine("Hobbies:");
            foreach (string hobby in usuarioEncontrado.Hobbies)
            {
                Console.WriteLine($"- {hobby}");
            }
        }
        else
        {
            Console.WriteLine($"Usuario con número de identificación {numeroUsuario} no encontrado.");
        }

}


static void eliminarUsario(){



        Console.Write("Ingresa el número de identificación del usuario: ");
        string? numeroUsuario = Console.ReadLine();

        // Verificar si el usuario existe en el diccionario
        if (usuarios.TryGetValue(numeroUsuario, out Usuario usuarioEncontrado))
        {
          usuarios.Remove($"{numeroUsuario}");
        }
        else
        {
            Console.WriteLine($"Usuario con número de identificación {numeroUsuario} no encontrado.");
        }

}

}