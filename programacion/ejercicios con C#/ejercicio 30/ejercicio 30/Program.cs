namespace ejercicio_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d;
            Console.Write("ingrese primer nota del alumno ");
            a=int.Parse(Console.ReadLine());
            Console.Write("ingrese la segunda nota del alumno ");
            b=int.Parse(Console.ReadLine());
            Console.Write("ingrese la tercer nota del alumno ");
            c=int.Parse(Console.ReadLine());
            d = (a + b + c) / 3;
            
            if (d <4)
            {
                Console.Write(" usted esta aplazado");
            }
            if (d <= 4)
            {
                Console.Write(" usted desaprobo");
            }
            else
            {
                if (d >= 7)
                {
                    Console.Write(" usted aprobo");
                }

            }
            Console.WriteLine(" el promedio es ", d);
        }
    }
}
