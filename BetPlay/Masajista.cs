namespace BetPlay
{
    public class Masajista : Federacion
    {
        public string titulacion { get; set; }
        public int añosExp { get; set; }

        public Masajista(string Nombre, int Edad, string CiudadOrigen, int Id, string Titulacion,int AñosExp) : base(Nombre,Edad,CiudadOrigen,Id){
            this.titulacion = Titulacion;
            this.añosExp = AñosExp;
        }

        public Masajista (){}


        public void agregarMasajista(Dictionary<int,Liga> equipos, Masajista nuevaMasajista,string equipo){   
            

            Console.Clear();
        

            foreach(var elemen in equipos.Values){

                foreach(var elemens in elemen.equipos.Values){

                    if(elemens.nombre == equipo){

                        Console.Clear();
                        Console.Write("\nIngresa el ID de la Masajista\t");
                        this.id = int.Parse(Console.ReadLine());

                        Console.Write("\nIngresa el Nombre de la Masajista\t");
                        nombre = (Console.ReadLine());

                        Console.Write("\nIngresa la Edad de la Masajista\t");
                        edad = int.Parse(Console.ReadLine());

                        Console.Write("\nIngresa la Ciudad de origen del Entrenador\t");
                        ciudadOrigen = Console.ReadLine();

                        Console.Write("\nIngresa la Titulacion de la Masajista\t");
                        titulacion = Console.ReadLine();

                        Console.Write("\nIngresa los años de Experiencia de la masajista\t");
                        añosExp = int.Parse(Console.ReadLine());
                        
                        elemens.masajistas
                        .Add(id,nuevaMasajista);
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