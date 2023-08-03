using BetPlay;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int,Liga> Ligas = new Dictionary<int,Liga>();


        Menu inicio = new Menu();
        int opcion;

        do {
            inicio.menuPrincipal();
            opcion = inicio.PedirOpcion();

            switch (opcion) {
                case 1: //---------------------------------------------------------------------------------------------
                    inicio.menuPlantel();
                    opcion =inicio.PedirOpcion();

                    switch (opcion) {
                        case 1:
                            Equipo nuevoEquipo = new Equipo();
                            nuevoEquipo.RegistrarEquipo(Ligas,nuevoEquipo);
                            break;
                        case 2:
                        

                            break;
                        default:
                            Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                            break;}
                    break;



                case 2://------------------------------------------------------------------------------------------------------------------------
                    inicio.menuConsultar();
                    opcion = inicio.PedirOpcion();

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



                  case 3://------------------------------------------------------------------------------------------------------------------------
                    inicio.menuLiga();
                    int opcion2 = inicio.PedirOpcion();
                    Liga nuevaLiga = new Liga();
                    switch (opcion2) {
                        case 1:
                            nuevaLiga.agregarLiga();
                            Ligas.Add(nuevaLiga.id,nuevaLiga);
                            break;

                        case 2:
                            nuevaLiga.mostrarLigas(Ligas);
                            break;

                        case 3:
                        break;

                        default:
                            Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                            break;}
                    break;



                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;
}} while (opcion != 4);
}
}
