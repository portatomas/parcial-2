namespace ejercicio_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayor, menor, medio;
            int a, b, c;
            Console.Write("ingrese el primer valor (a) " );
            a=int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo valor (b) " );
            b=int.Parse(Console.ReadLine());
            Console.Write("ingrese el tercer valor (c) " );
            c=int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    mayor = a;
                    if (b > c)
                    {
                        medio= b;
                        menor = c;
                    }
                    else
                    {
                        medio= c;
                        menor = b;
                    }
                }
                else
                {
                    mayor = c;
                    medio = a;
                    menor = b;
                }

            }
            else
            {
                mayor =c;
                medio = b;
                menor = a;

            }
            Console.WriteLine($" el numero mayor es", mayor);
            Console.WriteLine($" el numero medio es", medio);
            Console.WriteLine($" el numero menor es", menor);
        }
    }
}