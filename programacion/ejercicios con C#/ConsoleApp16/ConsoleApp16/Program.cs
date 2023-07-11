using System.ComponentModel.Design;

double numeroingresado;
Console.Write("ingrese un numero");
numeroingresado = double.Parse(Console.ReadLine());
if (numeroingresado >= 0)
{
    Console.WriteLine($"{numeroingresado} es positivo");
}
else
{
    Console.WriteLine($"{numeroingresado} es negativo");
}




