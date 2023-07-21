
//------------------------------ Esctrucura Do While ----------------------------------------------------


//Console.Write("Ingresa el límite de la suma: ");
// int limite = Convert.ToInt32(Console.ReadLine());

// int suma = 0;
// int numero;

// Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");

// do{ 
//     numero = Convert.ToInt32(Console.ReadLine());


//     suma += numero;
// }while (numero != 0 && suma <= limite ); 

// Console.WriteLine($"La suma total es: {suma}");





//------------------------------ Esctrucura For ----------------------------------------------------

// for(int i = 1; i<=5; i++){
//     Console.WriteLine($"For numero {i}");
// }



//------------------------------ Esctrucura Foreach ----------------------------------------------------


int [] numeros = {50,30,20,40,10};

foreach(int n in numeros){
    Console.WriteLine(n);
}

Array.Sort(numeros); // ordenar de menor a mayor


foreach(int n in numeros){
Console.WriteLine(n);}