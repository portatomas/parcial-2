namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double ladomayor, ladomenor;
            double perimetro, superficie;
            Console.Write("ingrese el valor del lado mayor");
            ladomayor=double.Parse(Console.ReadLine());
            Console.Write("ingrese el valor del lado menor");
            ladomenor=double.Parse(Console.ReadLine());

            perimetro = calcularperimerrectangulo(ladomayor, ladomenor);
            superficie=calcularsuperficierectangulo(ladomayor,ladomenor);

            Console.WriteLine($"la superficie es {superficie}");
            Console.WriteLine($"el perimetro es {perimetro}");
            
        }

        private static double calcularperimerrectangulo(double ladomayor, double ladomenor)
        {
           return 2* ladomayor +2 * ladomenor;
        }

        private static double calcularsuperficierectangulo(double ladomayor, double ladomenor)
        {
           return ladomayor * ladomenor;
        }

        
         
        }
    }
