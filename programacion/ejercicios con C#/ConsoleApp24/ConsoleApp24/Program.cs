using System.ComponentModel.Design;

int a;
int b;


Console.Write("ingrese el primer numero (a) ");
a=int.Parse(Console.ReadLine());
Console.Write("ingrese el segundo numero (b) ");
b=int.Parse(Console.ReadLine());
if (a % b == 0)
    Console.WriteLine(" el numero a{0},es multiplo del numero b {1} ", a, b);
else
    Console.WriteLine(" el numero a{0},no es multiplo del numero b {1} ", a, b);

    Console.WriteLine("operacion invalida");


