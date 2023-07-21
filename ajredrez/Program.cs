string [] tableroLetras = {"a","b","c","d","e","f","g","h"};
string [] tableroNumeros = {"1","2","3","4","5","6","7","8"};

int [] posicionesLetras = {2,2,-2,-2,1,-1,1,-1};
int [] posicionesNumeros = {1,-1,1,-1,2,2,-2,-2};

string posicion1;
string posicion2;


Console.WriteLine("a  b  c  d  e  f  g  h");
Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");
Console.WriteLine("4");
Console.WriteLine("5");
Console.WriteLine("6");
Console.WriteLine("7");
Console.WriteLine("8");


Console.WriteLine("\nEscribe el numero de la Fila donde se ubica el caballo");
posicion1 =Console.ReadLine();


Console.WriteLine("\nEscribe la letra de la Columna donde se ubica el caballo");
posicion2 = Console.ReadLine();


int pos1 = Array.IndexOf(tableroNumeros,$"{posicion1}");
int pos2 = Array.IndexOf(tableroLetras,$"{posicion2}");



Console.WriteLine("--------------------------------------");


for(int i = 0; i<8; i++){
     try{

    if (tableroNumeros[pos1+(posicionesNumeros[i])] != "" && tableroLetras[pos2+(posicionesLetras[i])] != ""){
    Console.WriteLine($"El caballo se puede mover {tableroNumeros[pos1+(posicionesNumeros[i])]} {tableroLetras[pos2+(posicionesLetras[i])]}");
}
}catch{
    
}
}




