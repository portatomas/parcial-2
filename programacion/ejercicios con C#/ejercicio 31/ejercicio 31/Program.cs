namespace ejercicio_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayor, medio, menor;
            int a, b, c;
            Console.Write("ingrese el primer valor ");
            a=int.Parse(Console.ReadLine());
            Console.Write("ingrese el segundo valor ");
            b=int.Parse(Console.ReadLine());
            Console.Write("ingrese el tercer valor ");
            c=int.Parse(Console.ReadLine());
            if (a > b)
            {

            }
            else
            {
                mayor = c;
                medio=b;
                menor = a;
            }
            if (a > c)
            {
                mayor = a;
            }
            else
            {
                mayor = c;
                medio = a;
                menor = b;
            }
            if (b > c)
            {
                medio = b;
                menor=c;
            }
            else
            {
                medio = c;
                menor = b;
            }
            Console.WriteLine($"el numero mayor es ", mayor);
            Console.WriteLine($"el numero del medio es ", medio);
            Console.WriteLine($"el numero menor es " ,menor);
        }
    }
}