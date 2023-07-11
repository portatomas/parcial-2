namespace ejercicio_42
{
    internal class Program
    {
        
        private static double celsius;

        static void Main(string[] args)
        {
            int celsius, opcion;
            double conversiondetemp;
            string escalaconvertira;
            Console.Write("ingrese el valor de la temperatura en grados celsius");
            celsius = int.Parse(Console.ReadLine());
            Console.Write("1-fahrenheit");
            Console.Write("2-reaumur");
            Console.Write("3-kelvin");
            Console.Write("4-rankine");
            Console.WriteLine("ingrese opcion a convertir");
            opcion = int.Parse(Console.ReadLine());
            int temperatura = 0;
            var fah = conversiondecelsiusafahrenheit(temperatura);
            
            var reaumur = conversiondecelsiusareaumur(temperatura);
            var kelvin = conversiondecelsiusakelvin(temperatura);
            var rankine = conversiondecelsiusarankine(temperatura);
            
        }

       

        private static object conversiondecelsiusarankine(int temperatura)
        {
            return 1.8 * celsius + 491.67;
        }

        private static object conversiondecelsiusakelvin(int temperatura)
        {

            
            return celsius + 273.15;
        }

        private static object conversiondecelsiusareaumur(int temperatura)
        {
            return 0.8 * temperatura;
        }

        private static double conversiondecelsiusafahrenheit(int temperatura)
        {
            return 1.8 * temperatura + 32;
        }

    }
}