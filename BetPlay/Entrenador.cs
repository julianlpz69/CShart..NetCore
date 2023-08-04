namespace BetPlay
{
    public class Entrenador : Federacion
    {
        public long codigoFederacion { get; set; }
        public string especialidad { get; set; }

        public Entrenador(string Nombre, int Edad, string CiudadOrigen, int Id, long CodigoFederacion, string Especialidad) : base(Nombre,Edad,CiudadOrigen,Id){
            this.codigoFederacion = CodigoFederacion;
            this.especialidad = Especialidad;
        }

        public Entrenador(){}

        public void agregarEntrenador(Dictionary<int,Liga> equipos, Entrenador nuevoJugador,string equipo){   
            

            Console.Clear();


            foreach(var elemen in equipos.Values){

                foreach(var elemens in elemen.equipos.Values){

                    if(elemens.nombre == equipo){

                        Console.Clear();
                        Console.Write("\nIngresa el ID del Entrenador\t");
                        this.id = int.Parse(Console.ReadLine());

                        Console.Write("\nIngresa el Nombre del Entrenador\t");
                        nombre = (Console.ReadLine());

                        Console.Write("\nIngresa la Edad del Entrenador\t");
                        edad = int.Parse(Console.ReadLine());

                        Console.Write("\nIngresa la Ciudad de origen del Entrenador\t");
                        ciudadOrigen = Console.ReadLine();

                        Console.Write("\nIngresa el Codigo de Federacion de Entrenador\t");
                        codigoFederacion = long.Parse(Console.ReadLine());

                        Console.Write("\nIngresa la Especialidad del Entrenador\t");
                        especialidad = Console.ReadLine();

                        elemens.entrenadores.Add(id,nuevoJugador);
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