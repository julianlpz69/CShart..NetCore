using Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        

        List<Estudent> clase = new List<Estudent>()
        {
            new Estudent(){name = "Julian", edad = 19, cc = 27891},
            new Estudent(){name = "Carlos", edad = 21, cc = 55555},
            new Estudent(){name = "Pedro", edad = 25, cc = 888888},
            new Estudent(){name = "David", edad = 18, cc = 11111},
            new Estudent(){name = "Pako", edad = 222, cc = 0000},
        };


        List<Profesor> profes = new List<Profesor>()
        {
            new Profesor(){name = "Sancho", añosExpe = 10, area = "Matematicas", estudent = "David"},
            new Profesor(){name = "Miguel", añosExpe = 5, area = "Lenguas", estudent = "Julian"},
            new Profesor(){name = "Roy", añosExpe = 7, area = "Ingles", estudent = "Pedro"},
            new Profesor(){name = "Daniela", añosExpe = 15, area = "Psicologia", estudent = "Julian"},
            new Profesor(){name = "Karla", añosExpe = 15, area = "Psicologia", estudent = "Carlos"},
        };

    //SELECT- SOLO GUARDAR DATOS SIN CONDICIONAL
        var names = from estudent in clase
                    select estudent.name; //Solo un tipo de datos
        
        var namesYedads = from estudent in clase
                    select new {estudent.name , estudent.edad};//Varios tipos de datos se tiene que crear un objeto

        foreach(var estudiante in namesYedads){
            Console.Write($"\n{estudiante.name}  {estudiante.edad}");
        }



        Console.Write("\n------------------------------------------------------------\n");
        //wHERE- GUARDAR DATOS CON COINDICIONAL WHERE  ---------------------------------------
        var names2 = from estudent in clase
                    where estudent.edad >=20
                    select estudent.name;

        Console.Write("\n-----MAYORES DE 20 AÑOS-----");
        foreach(var nombres in names2){
            Console.Write($"\n{nombres}");
        }



        Console.Write("\n------------------------------------------------------------\n");
        //Orden By ---------------------------------------
        var names3 = from estudent in clase
                    where estudent.edad >=17
                    orderby estudent.name //descending se usar para ordenar alrevez
                    select new {estudent.name , estudent.edad};

        Console.Write("\n-----Orden Alfabetico-----");
        foreach(var nombres in names3){
            Console.Write($"\n{nombres.name} {nombres.edad}");
        }



        Console.Write("\n------------------------------------------------------------\n");
        //Gruop By ---------------------------------------
        var names4 = from estudent in clase
                    group estudent by estudent.name into nuevo
                    select new{
                        nombre= nuevo.Key,
                        cantidad = nuevo.Count(),
                    };

        Console.Write("\n-----Agrupar por nombre-----");
        foreach(var nombres in names4){
            Console.Write($"\n{nombres.nombre} {nombres.cantidad}");
        }


        Console.Write("\n------------------------------------------------------------\n");
        //join sacar datos de dos colecciones ---------------------------------------
        var names5 = from estudent in clase
                    join profe in profes on estudent.name equals profe.estudent
                    select new{
                        nombre= estudent.name,
                        nombreProfe = profe.name,
                    };

        Console.Write("\n-----Unir datos de dos colecciones-----");
        foreach(var nombres in names5){
            Console.Write($"\n{nombres.nombre} {nombres.nombreProfe}");
        }









    }
}