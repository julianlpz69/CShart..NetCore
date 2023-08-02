class Program {
    

    static Dictionary<int,Producto> productos = new Dictionary<int,Producto>();


    class Producto
{
    // Propiedades de la clase Usuario
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Inventario {get; set;}
    public List<string> Clientes { get; set; }

    // Constructor de la clase Usuario
    public Producto(int codigo ,string nombre, double precio, int inventario, List<string> clientes)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Inventario = inventario;
        Clientes = clientes;
    }

    void mostrarDetalles(){
        Console.WriteLine($"Codigo: {Codigo}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"Cantidad de Inventario: {Inventario}");
        Console.WriteLine($"-----Clientes------");
        foreach (string clientes in Clientes)
        {
            Console.WriteLine($"- {clientes}");
        }
    }

    void actualizarPrecio(double nuevoPrecio){
        Precio = nuevoPrecio;
    }

    void actualizarInventario(int nuevoInventario){
        Inventario = nuevoInventario;
    }

    void actualizarClientes(List<string> clientes){
        Clientes = clientes;
    }
}




    static void Main() {


        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
        agregarProducto();
                    break;
                case 2:
            mostrarUsuario();
                    ;
                    break;
                case 3:

                break;
                case 4:
    
                    break;

                case 5:
    
                    break;    
                default:
                    Console.WriteLine("/nOpción inválida. Inténtalo de nuevo.");
                    break;
}} while (opcion != 6);
}


    static void MostrarMenu() {
        Console.WriteLine("\nMenú de opciones:");
        Console.WriteLine("\n1. Agregar Producto");
        Console.WriteLine("2. Mostrar Detalles de Producto");
        Console.WriteLine("3. Mostrar Todos los Productos");
        Console.WriteLine("4. Actualizar Invenario de un Producto");
        Console.WriteLine("5. Actualizar CLientes de un Producto");
        Console.WriteLine("6. Salir");
    }

    static int PedirOpcion() {
        Console.Write("\nElige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }


    static void agregarProducto(){
        Console.Clear();
        Console.Write("\nIngresa el Codigo del Producto: ");
        int codigo = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        Console.Write("\nIngresa el nombre del Producto: ");
        string? nombre = Console.ReadLine();
        Console.Write("\nIngresa el Precio del Producto: ");
        double precio = double.TryParse(Console.ReadLine(), out double results) ? results : 0.0;
        Console.Write("\nIngresa el numero de Inventario: ");
        int inventario = int.TryParse(Console.ReadLine(), out int resultss) ? resultss : 0;

        List<string> clientes = new List<string>();
        string? cliente;
         do{
            Console.Write("Ingresa los Clientes Asociados a este Producto (o escribe 'fin' para terminar): ");
            cliente = Console.ReadLine() ;

            if (cliente?.ToLower() != "fin")
    {
        clientes.Add($"{cliente}");
    }
} while (cliente?.ToLower() != "fin");

    Producto producto = new Producto(codigo,nombre,precio,inventario,clientes);

    Console.WriteLine($"{producto.Nombre}");

    Program.productos.Add(codigo, producto);
}



static void mostrarUsuario(){

        Console.Clear();

        Console.Write("\nIngresa el Codigo del Producto: ");
        int codigo = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        // Verificar si el usuario existe en el diccionario
        if (productos.TryGetValue(codigo, out Producto usuarioEncontrado))
        {
            // Imprimir los datos del usuario encontrado
            Console.WriteLine($"Codigo: {codigo}:");
            Console.WriteLine($"Nombre: {usuarioEncontrado.Nombre}");
            Console.WriteLine($"Precio: {usuarioEncontrado.Precio}");
            Console.WriteLine($"Inventario: {usuarioEncontrado.Inventario}");
            Console.WriteLine("Hobbies:");
            foreach (string cliente in usuarioEncontrado.Clientes)
            {
                Console.WriteLine($"- {cliente}");
            }
        }
        else
        {
            Console.WriteLine($"Usuario con número de identificación {codigo} no encontrado.");
        }

}


}