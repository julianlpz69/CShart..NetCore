namespace Automotriz
{
        public class Menu
    {
        public Menu(){

        }

        public void menuPrincipal(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Menu Principal -----------------");
            Console.WriteLine("\n1. Regitro De Plantel");
            Console.WriteLine("2. Orden de Servicio");
            Console.WriteLine("3. Cierre de Servicio");
            Console.WriteLine("4. Salir");
        }

        public void menuPlantel(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Registro Del Plantel -----------------");
            Console.WriteLine("\n1. Registrar Cliente");
            Console.WriteLine("2. Registrar Vehiculo");
            Console.WriteLine("3. Registrar Empleado");
            Console.WriteLine("4. Regresar al Menu Principal");
        }

        public int PedirOpcion() {
            Console.Write("\nElige una opción:\t");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}