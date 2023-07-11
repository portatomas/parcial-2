namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fah, reaumur;
            Console.Write("ingrese el valor de la temperatura en grados celsius");
            celsius = double.Parse(Console.ReadLine());
            fah = convertirDEcelsiusAFah(celsius);
            reaumur = convertirDEcelsiusAReaumur(celsius);
            Console.WriteLine($"{celsius} grados c equvalen a {fah} grados f");
        }

        private static double convertirDEcelsiusAReaumur(double temperatura)
        {
            return 0.8 * temperatura;
        }

        private static double convertirDEcelsiusAFah(double celsius)
        {
            return 1.8 * celsius + 32;
        }
    }
}