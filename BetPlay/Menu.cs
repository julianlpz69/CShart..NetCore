namespace BetPlay
{
    public class Menu
    {
        public Menu(){

        }

    public void menuPrincipal(){
        Console.Clear();
        Console.WriteLine("\n ---------------------- Menu Principal -----------------");
        Console.WriteLine("\n1. Regitro De Plantel");
        Console.WriteLine("2. Consulta de Datos");
        Console.WriteLine("3. Salir");
    }

    public void menuPlantel(){
        Console.Clear();
        Console.WriteLine("\n ---------------------- Registro Del Plantel -----------------");
        Console.WriteLine("\n1. Registrar Equipo");
        Console.WriteLine("2. Registrar Jugador");
        Console.WriteLine("3. Registrar Entrenador");
        Console.WriteLine("4. Registrar Masajista");
        Console.WriteLine("5. Vender Jugador");
        Console.WriteLine("6. Regresar al Menu Principal");
    }

    public void menuConsultar(){
        Console.Clear();
        Console.WriteLine("\n ---------------------- Consulta de Datos -----------------");
        Console.WriteLine("\n1. Listar Jugadores Por Equipo");
        Console.WriteLine("2. Buscar Delantes de Cada Equipo");
        Console.WriteLine("3. Buscar Entrenadores por Equipo");
        Console.WriteLine("4. Regresar al Menu Principal");
    }



    }
}