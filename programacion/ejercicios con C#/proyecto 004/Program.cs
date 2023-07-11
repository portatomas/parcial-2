double lado;
double superficie, perimetro;
Console.Write("ingrese el valor del cudrado");
lado = Double.Parse(Console.ReadLine());
superficie = Math.Pow(lado, 2);// elevan al cuadrado el valor del lado
perimetro = lado * 4;
Console.WriteLine($"la superficie del cuadrado es{superficie}");
// console.writeline(" la superficie del cuadrado es {0},perimetro
Console.WriteLine("la superficie del perimetro es {0}", perimetro);



