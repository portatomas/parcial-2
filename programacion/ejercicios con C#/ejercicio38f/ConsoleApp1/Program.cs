namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el numero del mes " );
            var nromes = int.Parse(Console.ReadLine());
            if (validarmes(nromes))
            {
                var nombremes = devolvernombredelmes(nromes);
                var trimestre = devolvertrimestre(nromes);
                Console.WriteLine($"{nromes} corresponde al mes de {nombremes} que pertenece al { trimestre}");

            }
            else
            {
                Console.WriteLine("nro mes invalido");
            }


        }

        private static string devolvertrimestre(int nromes)
        {
            string nombre = "";
            switch (nromes)
            {
                case 1:
                    
                  
                case 2:
                   
                    
                case 3:
                    nombre = "primer trimestre";
                   
                    break;
                case 4:
                   
                    
                case 5:
                    
                    
                case 6:
                    nombre = "segundo trimestre";
                    
                    break;
                case 7:
                    
                    
                case 8:
                   
                    
                case 9:
                    nombre = "tercer trimestre";
                  
                    break;
                case 10:
                    
                    
                case 11:
                    
                    
                default:
                    nombre = "cuarto triestre";
                   
                    break;
            }
            return nombre;
        }

        private static string devolvernombredelmes(int nromes)
        {
            string nombre = "";
            switch (nromes)
            {
                case 1:
                nombre="enero";
                    break;
                    case 2:
                    nombre = "febrero";
                    break;
                    case 3:
                    nombre = "marzo";
                    break;
                    case 4:
                    nombre = "abril";
                    break;
                    case 5:
                    nombre = "mayo";
                    break;
                    case 6:
                    nombre = "junio";
                    break;
                    case 7:
                    nombre = "julio";
                    break;
                    case 8:
                    nombre = "agosto";
                    break;
                    case 9:
                    nombre = "septiembre";
                    break;
                    case 10:
                    nombre = "octubre";
                    break;  
                    case 11:
                    nombre = "noviembre";
                    break;
                default:
                    nombre = "diciembre";
                    break;  
            }
            return nombre;
        }

        private static bool validarmes(int nromes)
        {
            return nromes >= 1 && nromes<=12;
        }
    }
}