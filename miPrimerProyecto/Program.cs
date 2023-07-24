using System.Collections;

ArrayList miArrayList = new ArrayList();
miArrayList.Add(10);
miArrayList.Add("Hola");
miArrayList.Add(5.75);
miArrayList.Add("Mundo");

// Recorrer el ArrayList con un foreach
foreach (var elemento in miArrayList)
{      
        Console.WriteLine(elemento);
}