namespace BetPlay
{
    public class Equipo
    {
        public string nombre { get; set; }
        public List<string> propietario { get; set; }

        public Dictionary<int,Liga> jugadores { get; set; }
        public Dictionary<int,Liga> masajistas { get; set; }
        public Dictionary<int,Liga> entrenadores { get; set; }

        public Equipo(string Nombre){

            this.nombre = Nombre;
            this.propietario = new List<string>();
            this.jugadores = new Dictionary<int,Liga>();
            this.masajistas = new Dictionary<int,Liga>();
            this.entrenadores = new Dictionary<int,Liga>();
        }

        public Equipo(){}

        public void RegistrarEquipo(Dictionary<int,Liga> Ligas,Equipo equipo){

            Console.Write("\nIngresa el ID de la liga a la que Pertenece el Equipo\t");
            int id = int.Parse(Console.ReadLine());

            if (Ligas.TryGetValue(id, out Liga ligaEcontrada)){
                Console.Write("\nIngresa el Nombre del Equipo\t");
                nombre = Console.ReadLine();

                List<string> propietarios = new List<string>();
                string nombres;
                do{
                    Console.Write("Ingresa los nombres de Propetario (o escribe 'fin' para terminar): ");
                    nombres = Console.ReadLine();
                    if (nombres != "fin"){
                        propietario = propietarios;}

                } while (nombres.ToLower() != "fin");
        
                ligaEcontrada.equipos.Add(nombre,equipo);
    
                Console.Clear();
                Console.Write($"\nEl Equipo {nombre} a sido Registrado Correctamente presiona ENTER para Regresar al Menu Principal");
                Console.ReadKey();
            }
            else
            {
                Console.Write("ID No coincide con ninguna Liga Registrada");
                Console.ReadKey();
            }
        }
    }
}