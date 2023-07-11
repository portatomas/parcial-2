namespace ConsoleApp8_n_entero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("ingrese un numero entero");
            n=int.Parse(Console.ReadLine());
            n = (n * (n + 1)) / 2;
            Console.WriteLine($"el numero entero es: ",n);
        }
    }
}