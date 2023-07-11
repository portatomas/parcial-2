

using System.Runtime.CompilerServices;

Console.Write("ingrese un numero");
var numeroingresado = double.Parse(Console.ReadLine());
if (versiespositivo( numeroingresado))
{
    Console.WriteLine($"{numeroingresado} es positivo");
}
else
{
    Console.WriteLine($"{numeroingresado} es negativo");
}

 
private static bool versiespositivo(double numero)
{
    return numero >= 0;
}
     