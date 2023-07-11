using System.ComponentModel.Design;

Console.Write("conversion de temperaturas");
Console.Write("ingrese la temperatura");
var temperatura=double.Parse(Console.ReadLine());
Console.Write("ingrese escalab de la temperatura (C)elsius o (F)ahrenheit");
var escala=Console.ReadLine();
if (escala.ToUpper() == "C")
{
    var farehnheit = convertirdecelsiusafahrenheit(temperatura);
    Console.WriteLine($"{temperatura}grados c equivalen a {farehnheit}grados f");
} else if (escala.ToUpper() == "f") ;

var celsius = convertirdefahrenheitacelsius(temperatura);
Console.WriteLine($"{temperatura}grados f equivalen a {celsius}grados c");
{
else;
}
Console.WriteLine("escala mal ingresada");


   

double convertirdefahrenheitacelsius(double temperatura)
 { 

    return (temperatura - 32) * 5 / 9;
}

double convertirdecelsiusafahrenheit(double temperatura)
{
    return  (1.8*temperatura + 32);
     
}








    

 


