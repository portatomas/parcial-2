internal class Program
{
    private static void Main(string[] args)
    {
        double radianes;
        double valorradianes, valorhexagesimales;
        Console.Write("ingrese el valor en grados hexagesimales");
        valorhexagesimales = double.Parse(Console.ReadLine());

        valorradianes = valorhexagesimales*0.0174532295;
    }
}