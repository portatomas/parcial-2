using System.ComponentModel.Design;
using System.Timers;

double año;
Console.Write("ingrese año a evaluar");
año = double.Parse(Console.ReadLine());
{
    if (año % 4 == 0 && año % 100 != 0 && año % 400 == 0)
        Console.WriteLine($"{año} equivale a un año bisiesto");
}
else
{
    Console.WriteLine("El año ingresado no es bisiesto");
}





      





