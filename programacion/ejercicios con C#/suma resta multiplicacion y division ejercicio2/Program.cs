// See https://aka.ms/new-console-template for more information
// declarar vadiables

int primernumero;
int segundonumero;
int resultado;
//  pedir datos al usuario
Console.WriteLine("ingrese el primer numero:");
primernumero = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese el segundo numero:");
segundonumero = int.Parse(Console.ReadLine());
resultado = primernumero + segundonumero;//        realizar operaciones
Console.WriteLine($"los resultados son {resultado}");
resultado = primernumero / segundonumero;
Console.WriteLine($"los resultados son {resultado}");
resultado = primernumero - segundonumero;
Console.WriteLine($"los resultados son {resultado}");
resultado = primernumero * segundonumero;
Console.WriteLine($"los resultados son {resultado}");








