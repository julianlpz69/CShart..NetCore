using System.Collections;
//-------------------------------------- Arrays ---------------------------------------------------------------------------------------------

// int [] numeros = new int[7] {20,40,10,15,35,502,0};

// int primerNumero = numeros[0];                // Acceder al primer elemento de un array

// int ultimoNumero = numeros[numeros.Length-1]; // Acceder al ultimo numero de un array

// int pos1 = Array.IndexOf(numeros,10);         // Acceder al indice mediante el valor

// numeros[numeros.Length - 1]=3;

// Console.WriteLine(numeros[6]);


// // Para agregar y elminar valores en un array toca crear un nuevo array con un tamaño mas pequeño o mas grande y llevarle los datos

// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
//     Console.WriteLine(cars[0]);
//     cars[0] = "Opel";              // modificar un valor del array mediante su indice
//     Console.WriteLine(cars[0]);    







//-------------------------------------- ArrayList ---------------------------------------------------------------------------------------------



// ArrayList miArrayList = new ArrayList();
// miArrayList.Add(10);
// miArrayList.Add("Hola");
// miArrayList.Add(5.75);
// miArrayList.Add("Mundo");

// // Recorrer el ArrayList con un foreach
// foreach (var elemento in miArrayList)
// {      
//         Console.WriteLine(elemento);
// }







//-------------------------------------- Listas ---------------------------------------------------------------------------------------------

List<string> personNames = new List<string>();


personNames.Add("Kevin");        // Agregar Valores al final de la Lista
personNames.Add("Borja");
personNames.Add("Daniel");

Console.WriteLine(personNames[1]);


personNames.Insert(0, "Pepito"); // insertar un valor en un indice en especifico si en ese indice habia un valor, ese valor y todos los que le siguen se correran un puesto

Console.WriteLine(personNames[0]);


personNames.Remove("Pepito");    // Eliminar un valor de la lista los demas elementos despues de este se regresaran un puesto

Console.WriteLine(personNames[0]);


personNames.RemoveAt(0);         // Eliminar un valor de la lista mediante el indice los demas elementos despues de este se regresaran un puesto

Console.WriteLine(personNames[0]);