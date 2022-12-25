using System;

class Program {
  public static void Main (string[] args) {
    //Leer dos numeros enteros
    Console.WriteLine("Ingrese el valor de x:");
    string xString= Console.ReadLine();
    int x = Int32.Parse (xString);
    Console.WriteLine("Ingrese el valor de y:");
    string yString= Console.ReadLine();
    int y = Int32.Parse (yString);
    int z=0;
    //Almacenar el mayor en una variable z e imprimirla
    if (x>y)
      z=x;
    else
      z=y;
    Console.WriteLine("El mayor es:"+z);
  }
}