using System.ComponentModel.Design;

Console.Write("ingrese el primer numero");
var numero1= int.Parse(Console.ReadLine());
Console.Write("ingrese el segundo numero");
var numero2= int.Parse(Console.ReadLine());
if (numero1 == numero2)
{
    Console.WriteLine("ambos numeros son iguales");
}else  if (numero1 > numero2)   
{
    Console.WriteLine($"{numero1} es mayor a {numero2}");
}
else
{
    Console.WriteLine($"{numero2} es mayor a {numero1}");
}

    
