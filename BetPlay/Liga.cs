namespace BetPlay
{
    public class Liga
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Dictionary<string,Equipo> equipos { get; set; }


        public Liga(string Nombre, int ID){

            this.id = ID;
            this.nombre = Nombre;
            this.equipos = new Dictionary<string,Equipo>();

        }

        public Liga(){
                this.equipos = new Dictionary<string,Equipo>();
        }

        public void agregarLiga(){

            
        Console.Write("\nIngresa el Nombre de la Liga\t");
        this.nombre = Console.ReadLine();

        Console.Write("\nIngresa el Id de la liga\t");
        this.id = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write($"\nLa Liga {nombre} a sido Registrado Correctamente presiona ENTER para Regresar al Menu Principal");
        Console.ReadKey();
        }

        public void mostrarLigas(Dictionary<int,Liga> Ligas){
            Console.Clear();
            Console.WriteLine("--------------LIGAS------------------");
            Console.WriteLine("\nID\t\tNOMBRE");
            foreach (var elemento in Ligas)
                {      
                    Console.WriteLine($"\n{elemento.Key}\t\t{elemento.Value.nombre}");
                }
            Console.ReadKey();
        }

        
        

    }
}