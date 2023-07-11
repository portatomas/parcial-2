using System.ComponentModel.Design;

int lado1, perimetro, superficie;
string leerconsola;
Console.WriteLine("ingrese el valor del lado");
leerconsola = Console.ReadLine();
bool successfullyparsed = int.TryParse(leerconsola, out lado1);
if (successfullyparsed) ;


perimetro = (lado1 * 4);
superficie = (int)Math.Pow(lado1, 2);

if (lado1 <= 0) ;
{ Console.WriteLine("no se puede ingresar un valor igual o menorque a cero"); }

{ Console.WriteLine($"el perimetro del cuadrado es {perimetro} y la superficie es {superficie}"); }

{ Console.WriteLine("ingresa un lado valido"); }