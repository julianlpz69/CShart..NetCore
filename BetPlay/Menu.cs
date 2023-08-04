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
            Console.WriteLine("3. Ligas");
            Console.WriteLine("4. Salir");
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

        public void menuLiga(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Ligas -----------------");
            Console.WriteLine("\n1. Agregar Liga");
            Console.WriteLine("2. Mostrar Ligas");
            Console.WriteLine("3. Regresar al Menu Principal");
        }

        public int PedirOpcion() {
            Console.Write("\nElige una opción:\t");
            return Convert.ToInt32(Console.ReadLine());
        }
        

        public string recorrerEquipos(Dictionary<int,Liga> Ligas){
            Console.Clear();

                foreach (var elemento in Ligas.Values){      
                    foreach(var elemen in elemento.equipos.Keys){
                    Console.WriteLine($"\n#\t {elemen}");
                    }
                }

                Console.Write("\nA que Equipo Pertenece el Jugador?\t");
                return Console.ReadLine();
            }

        public void mostrarJugadores(Dictionary<int,Liga> Ligas ,string equipo){
            Console.Clear();

            foreach (var elemento in Ligas.Values){      
                foreach(var elemen in elemento.equipos.Values){
                    
                    if(elemen.nombre == equipo){
                        try{
                            Console.WriteLine($"Id\tNombre\tPosicion\tEdad");
                            foreach(var jugador in elemen.jugadores.Values){
                                Console.WriteLine($"\n{jugador.id}\t{jugador.nombre}\t{jugador.posicion}\t{jugador.edad}");
                            }


                        }catch{
                            Console.Write($"\nEl Equipo No tiene jugadores Registrados");
                        }
                    }
                }
            }
            Console.ReadKey();
        }    


        public void mostrarJugadoresDelantes(Dictionary<int,Liga> Ligas ,string equipo){
            Console.Clear();

            foreach (var elemento in Ligas.Values){      
                foreach(var elemen in elemento.equipos.Values){
                    
                    if(elemen.nombre == equipo){
                        try{
                            Console.WriteLine($"Id\tNombre\tPosicion\tEdad");
                            foreach(var jugador in elemen.jugadores.Values){
                                if(jugador.posicion.ToUpper() == "DELANTERO"){
                                Console.WriteLine($"\n{jugador.id}\t{jugador.nombre}\t{jugador.posicion}\t{jugador.edad}");
                                }
                            }


                        }catch{
                            Console.Write($"\nEl Equipo No tiene jugadores Registrados");
                        }
                    }
                }
            }
            Console.ReadKey();
        }


        public void mostrarEntrenadores(Dictionary<int,Liga> Ligas ,string equipo){
            Console.Clear();

            foreach (var elemento in Ligas.Values){      
                foreach(var elemen in elemento.equipos.Values){
                    
                    if(elemen.nombre == equipo){
                        try{
                            Console.WriteLine($"Id\tNombre\tEspecialiad\tCodigo Federacion");
                            foreach(var jugador in elemen.entrenadores.Values){
                                Console.WriteLine($"\n{jugador.id}\t{jugador.nombre}\t{jugador.especialidad}\t\t{jugador.codigoFederacion}");
                            }


                        }catch{
                            Console.Write($"\nEl Equipo No tiene jugadores Registrados");
                        }
                    }
                }
            }
            Console.ReadKey();
        }  


        public void comprarJugador(string equipo,Dictionary<int,Liga> Ligas){
            Console.Clear();
        
            Console.WriteLine($"\nIngrese el ID del Jugador");
            int id = int.Parse(Console.ReadLine());


            foreach (var elemento in Ligas.Values){      
                foreach(var elemen in elemento.equipos.Values){
                    
                    if(elemen.nombre == equipo){
                        try{
                                Jugador jugador = elemen.jugadores[id]; 
                                elemen.jugadores.Remove(id);

                                string nuevoEquipo = recorrerEquipos(Ligas);

                                foreach (var elementoss in Ligas.Values){      
                                    foreach(var ell in elementoss.equipos.Values){
                                        
                                        if(ell.nombre == nuevoEquipo){
                                        
                                            ell.jugadores.Add(jugador);

                                            Console.Write($"\nEl Jugador a sido vendido ha {ell.nombre} Exitosamente");
                                            Console.ReadKey();

                                        }
                                    }
                                }


                        }catch{
                            Console.Write($"\nEl Equipo No tiene ese jugador Registrados");
                        }
                    }
                }
            }
        }






    }  
}
