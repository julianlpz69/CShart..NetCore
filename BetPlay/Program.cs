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
                    int opcions =inicio.PedirOpcion();

                    switch (opcions) {
                        case 1:
                            Equipo nuevoEquipo = new Equipo();
                            nuevoEquipo.RegistrarEquipo(Ligas,nuevoEquipo);
                            break;
                        case 2:
                            Jugador nuevoJugador = new Jugador();
                            nuevoJugador.registrarJugador(Ligas,nuevoJugador,inicio.recorrerEquipos(Ligas));
                            break;

                        case 3:
                            Entrenador nuevoEntrenador = new Entrenador();
                            nuevoEntrenador.agregarEntrenador(Ligas,nuevoEntrenador,inicio.recorrerEquipos(Ligas));   
                            break; 
                        case 4:
                            Masajista nuevaMasajista = new Masajista();
                            nuevaMasajista.agregarMasajista(Ligas,nuevaMasajista,inicio.recorrerEquipos(Ligas));
                            break;
                        default:
                            Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                            break;}
                    break;



                case 2://------------------------------------------------------------------------------------------------------------------------
                    inicio.menuConsultar();
                    int opcio = inicio.PedirOpcion();

                    switch (opcio) {
                        case 1:
                            string equipo = inicio.recorrerEquipos(Ligas);
                            inicio.mostrarJugadores(Ligas,equipo);
                            
                            break;
                        case 2:
                            string equipo2 = inicio.recorrerEquipos(Ligas);
                            inicio.mostrarJugadoresDelantes(Ligas,equipo2);
                            break;
                        case 3:

                            inicio.mostrarEntrenadores(Ligas,inicio.recorrerEquipos(Ligas));
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
