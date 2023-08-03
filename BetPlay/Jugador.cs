namespace BetPlay
{
    public class Jugador : Federacion
    {
        public string dorsal { get; set; }
        public string posicion { get; set; }

        public Jugador(int Id,string Nombre, int Edad, string CiudadOrigen, string Dorsal,string Posicion) : base(Nombre,Edad,CiudadOrigen,Id){
            this.dorsal = Dorsal;
            this.posicion = Posicion;
        }

        public Jugador(){}
        public void registrarJugador(Dictionary<int,Liga> equiposss, Jugador nuevoJugador,string equipo){
            
            Console.Clear();


            foreach(var elemen in equiposss.Values){

                foreach(var elemens in elemen.equipos.Values){

                    if(elemens.nombre == equipo){

                        Console.Clear();
                        Console.Write("\nIngresa el ID del Jugador\t");
                        this.id = int.Parse(Console.ReadLine());

                        Console.Write("\nIngresa el Nombre del Jugador\t");
                        nombre = (Console.ReadLine());

                        Console.Write("\nIngresa la Edad del Jugador\t");
                        edad = int.Parse(Console.ReadLine());

                        Console.Write("\nIngresa la Ciudad de origen del Jugador\t");
                        ciudadOrigen = Console.ReadLine();

                        Console.Write("\nIngresa el Dorsal del Jugador\t");
                        dorsal = Console.ReadLine();

                        Console.Write("\nIngresa la Posicion del Jugador\t");
                        posicion = Console.ReadLine();

                        elemens.jugadores.Add(id,nuevoJugador);
                    }

                    else{
                        Console.Write("\nEl Nombre ingresado no pertenece a ningun equipo");
                        Console.ReadKey();
                    }
                }

        


            
            
            }
            
        
        }
    }   
}