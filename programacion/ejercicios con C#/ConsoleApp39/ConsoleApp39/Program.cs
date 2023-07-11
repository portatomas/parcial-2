namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("convertir a nuumero romano");
                Console.Write("ingrese un numero.entero entre 1 y 10 ");
                var numeroingresado = int.Parse(Console.ReadLine());
                if (numeroingresado >= 1 && numeroingresado <= 10)
                {
                    string numeroromano = convertiranumeroromano(numeroingresado);
                    Console.WriteLine($"{numeroingresado} equivale a {numeroromano} en notacion romana");
                }
                else
                {
                    Console.WriteLine("numero ingresaro fuera del rango prmitido");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("numero ingresado no es valido");
            }
            Console.ReadLine(); 
        }

        private static string convertiranumeroromano(int numeroingresado)
        {
            string romano = "";
            switch (numeroingresado)
            {
                case 1:
                    romano = "I";
                    break;
                    case 2:
                    romano="II";
                    break;
                    case 3:
                    romano = "XXX";
                    break;
                    case 4:
                    romano = "IV";
                    break;
                    case 5:
                    romano = "V";
                    break;
                    case 6:
                    romano = "VI";
                    break;
                    case 7:
                    romano = "VII";
                    break;
                    case 8:
                    romano = "VIII";
                    break;
                    case 9:
                    romano = "IX";
                    break;
                default:
                    romano = "X";
                    break;
                
                        
            }
            return romano;
        }
    }
            
}