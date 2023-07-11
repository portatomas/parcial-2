// See https://aka.ms/new-console-template for more information
double celsius, fah, reaumur;
double resultado;
Console.WriteLine("este programa convierte los grados celsius a grados reumur y de celsius a reaumur");

Console.Write("ingrese un valor en grados celsius");
celsius=double.Parse(Console.ReadLine());
resultado=( reaumur=0.8 * celsius);
Console.WriteLine();
resultado = ( fah=1.8 * celsius + 32);
Console.WriteLine("la temperatura en grados celsius convertida en reaumur es:", reaumur);
Console.WriteLine("la temperatura en grados celsius convertida en fah es:", fah);

