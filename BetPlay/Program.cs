using BetPlay;
internal class Program
{
    private static void Main(string[] args)
    {
        
        Menu inicio = new Menu();
        int opcion;

        do {
            inicio.menuPrincipal();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1: //---------------------------------------------------------------------------------------------
                    inicio.menuPlantel();
                    opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    RegistrarEquipo();
                    break;
                case 2:
                    inicio.menuConsultar();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;
}





                    break;
                case 2://------------------------------------------------------------------------------------------------------------------------
                    inicio.menuConsultar();
                  opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    inicio.menuPlantel();
                    Console.ReadLine();
                    break;
                case 2:
                    inicio.menuConsultar();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;}
                    break;




                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;
}} while (opcion != 3);
}

    static int PedirOpcion() {
        Console.Write("\nElige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void RegistrarEquipo(){

        Console.Write("\nIngresa el Nombre del Equipo");
        string nombre = Console.ReadLine();
        Console.Write("\nIngresa el año de Fundacion del Equipo");
        int añoFundacion = int.Parse(Console.ReadLine());
        Console.Write("\nIngresa el nombre del Propietario del Equipo");
        string nombrePropietario = Console.ReadLine();
        Console.Write("\nIngresa la Ciudad de Origen Del Equipo");
        string ciudadOrigen = Console.ReadLine();

        Equipo nuevo = new Equipo(nombre,añoFundacion,nombrePropietario,ciudadOrigen);

        Console.Clear();
        Console.Write($"\nEl Equipo {nombre} a sido Registrado Correctamente presiona ENTER para Continuar");
        Console.ReadKey();

    }


    }
