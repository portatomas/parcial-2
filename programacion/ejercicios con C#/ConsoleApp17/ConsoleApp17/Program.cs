Console.Write("ingre un numero entero");
var numero=int.Parse(Console.ReadLine());
if (numeroespar(numero))
{
    Console.WriteLine($"{numero} es par");
}
else
{
    Console.WriteLine($"{numero} es impar");
}

bool numeroespar(int numero)
{
    return numero %2== 0;
}



