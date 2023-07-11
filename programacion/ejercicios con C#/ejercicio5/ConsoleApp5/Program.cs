double superficie, radio, perimetro;
Console.Write("ingrese el valor de radio de la circunferencia");
radio=double.Parse(Console.ReadLine());
perimetro = 2 * radio * Math.PI;
superficie = Math.PI * Math.Pow(radio, 2);
Console.WriteLine($"una circ de radio {radio} tiene un perimetro de {perimetro} y una superficie {superficie}");
// se calcula superficie y perimetro
