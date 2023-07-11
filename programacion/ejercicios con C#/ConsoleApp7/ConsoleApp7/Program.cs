double sumaenpesos;
double sumaendolaroficial;
double sumaendolarparalelo;
double cotizacionendolaroficial;
double cotizacionendolarparalelo;

Console.WriteLine("este programa informa el valor del dolar oficial y del dolar paralelo diciendo su equivalente en pesos");

Console.Write("ingrese la cotizacion del dolar oficial ");
cotizacionendolaroficial = double.Parse(Console.ReadLine());
Console.Write("ingrese la cotizacion del dolar paralelo ");
cotizacionendolarparalelo = double.Parse(Console.ReadLine());
Console.Write("la cotizacios de pesos a invertir ");
sumaenpesos = double.Parse(Console.ReadLine());

sumaendolaroficial = sumaenpesos / cotizacionendolaroficial;
sumaendolarparalelo = sumaenpesos / cotizacionendolarparalelo;


Console.WriteLine ($"equivalen a ", sumaenpesos / cotizacionendolaroficial);
Console.WriteLine($"sumaenpesos , equivalen a sumaendolarparalelo");

Console.Write("toque una tecla para finalizar progrma");