namespace ejercicio_50_ciclos
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {

                int valorinicial = 0, valorfinal = 0;
                do 
                {
                      Console.WriteLine("ingrese el valor inicial en celsius ");
                    var str= Console.ReadLine();
                    if(int.TryParse(str, out valorinicial))
                    {
                        break;
                    }
                    Console.WriteLine("numero mal ingresado");
                }while (valorinicial != 0);
              
                valorinicial = int.Parse(Console.ReadLine());
                Console.Write("ingrese el valor final en celsius ");
                valorfinal = int.Parse(Console.ReadLine());

                Console.Write(" tabla de conversiones");
                if (valorfinal<valorfinal)
                {
                    if (valorinicial<valorfinal)
                    {
                        for (int celsius = 1; celsius <= 30; celsius++)
                        {
                            var fahrenheit = convertircelsiusfahrenheit(celsius);
                            Console.WriteLine($"celsius {celsius}-{fahrenheit:n2} fahrenheit");
                        }
                    }
                }
                else
                {
                    for (int celsius = 1; celsius >= 30; celsius--)
                    {
                        var fahrenheit = convertircelsiusfahrenheit(celsius);
                        Console.WriteLine($"celsius {celsius}-{fahrenheit:n2} fahrenheit");
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine(" algo anda mal consultelo con cristian");
            }

        }

        private static double convertircelsiusfahrenheit(int celsius)
        {
            return 1.8 * celsius + 32;
        }
    }
}