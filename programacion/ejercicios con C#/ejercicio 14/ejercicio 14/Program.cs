namespace ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pisos, altura,alturadeedificio;
            Console.Write("ingrese la cantidad de los pisos ");
            pisos=double.Parse(Console.ReadLine());
            Console.Write(" ingrese la altura de los pisos ");
            altura = double.Parse(Console.ReadLine());
            alturadeedificio = pisos * altura;
            Console.WriteLine($" la altura  totaldel edificio es: ", alturadeedificio);
        }
    }
}