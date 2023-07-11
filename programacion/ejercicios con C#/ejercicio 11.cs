namespace ConsoleApp11_lado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladomayor, ladomenor, perimetro, superficie;

            Console.Write("ingrese el valor de lado menor");
             ladomenor=double.Parse(Console.ReadLine());
            Console.Write("ingrese el valor de lado mayor");
            ladomayor=double.Parse(Console.ReadLine());
            perimetro = 2 * ladomayor + 2 * ladomenor;
            
            superficie = ladomayor * ladomenor;
            

            Console.WriteLine("el perimetro del rectangulo es :" ,perimetro);
            Console.WriteLine("la superficie del rectangulo es :", superficie);
        }
    }
}