using System.Security.Cryptography.X509Certificates;

namespace ejercicio54mientras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("divisor de un numero");
            Console.WriteLine("ingrese un numero");
            var n=int.Parse(Console.ReadLine());
            while (x<-n)
            {
                x =x + 1;
                if (n%x== 0)
                {
                    Console.WriteLine("el:" , x,  " es divisor de ", n);
                }

            }
        }
    }
}