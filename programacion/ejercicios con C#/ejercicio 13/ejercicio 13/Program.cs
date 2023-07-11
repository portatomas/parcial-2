namespace ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("escribe el cateto a " );
            a = double.Parse(Console.ReadLine());
            Console.Write("escribe el cateto b " );
            b = double.Parse(Console.ReadLine());
            c=(a*a) + (b*b);
            Console.WriteLine($"la hipotenusa del cuadrado es: ", c);
        }
    }
}