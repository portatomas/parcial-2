using System.ComponentModel.Design;

double lado1, lado2, lado3;
Console.Write("ingrese el valor del lado1 " );
lado1=double.Parse(Console.ReadLine());
Console.Write("ingrese el valor del lado2 ");
lado2=double.Parse(Console.ReadLine());
Console.Write("ingrese el valor del lado3 ");
lado3=double.Parse(Console.ReadLine());
if (lado1 == lado2 && lado2 == lado3)

    Console.WriteLine("los lados corresponden aun triangulo equilatero");
else if (lado1 == lado2 && lado1 == lado3)

    Console.WriteLine("los lados corresponden a un triangulo isoseles");
else if (lado1 != lado2 && lado2 != lado3);


Console.WriteLine("los lados corresponden a un triangulo escaleno");
