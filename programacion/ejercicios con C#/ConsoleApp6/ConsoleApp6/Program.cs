// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double millas;
double yardas;

double valor1;
double valor2;
double valor3;
Console.WriteLine("este programa toma distancia expresad en kilometros y muestra su equivalente en millas y yardas");
Console.Write("ingrese el valor el  cual desea convertir");
valor1 = double.Parse(Console.ReadLine());
valor2: millas = valor1 * 0.621371192;
valor3: yardas = valor1 * 1093.61;
Console.WriteLine($"el valor expresado en millas es: {valor1}");
Console.WriteLine($"el valor expresado en yardas es: {valor1}");