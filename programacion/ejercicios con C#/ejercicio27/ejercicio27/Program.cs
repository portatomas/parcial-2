using System.ComponentModel.Design;

namespace ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.Write("ingrese un caracter " );
            letra = Console.ReadLine();
            if (letra == "a" && letra == "e" && letra == "i" && letra == "o" && letra == "u") 
            {
                Console.WriteLine( " el caracter" , letra,  "es una vocal");
            }
            
            if (letra == "A" && letra == "E" && letra == "I" && letra == "O" && letra == "U" ) 
            {
                Console.WriteLine(" el caracter", letra, "es una vocal");
            }
            else
            {
                Console.WriteLine("el caracter", letra, "es una consonante");
            }
            
            
           
            }
            
        }
        
    }

