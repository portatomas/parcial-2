namespace ejercicio_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("ingrese el primer lado ");
            a=int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo lado ");
            b=int.Parse(Console.ReadLine());
            Console.Write("ingrese el tercer lado ");
            c=int.Parse(Console.ReadLine());
            if (a*a == b*b+c*c)
            {
                Console.WriteLine(" se forma un triangulo rectangulo");
            }
            if (a*a > b*b+c*c)
            {
                Console.WriteLine("se forma un triangulo obtusangulo");
            }
            else if (a*a < b*b + c * c)
            {
                Console.WriteLine(" se forma un triangulo acutangulo");
            }
        }
    }
}