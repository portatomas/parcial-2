using System.Security.Cryptography.X509Certificates;

namespace ejercicio_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write(" ingrese una coordenada en x ");
           x=int.Parse(Console.ReadLine());
            Console.Write("ingrese una coordenada en y ");
            y=int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.Write("punto en el el primer cuadrante");
            }
            else if(x > 0 && y < 0)
             {
                Console.Write(" punto en el segundo cuadrante");
             }  
             if (x< 0 && 0 < y)
            {
                Console.Write("punto en el tercer cuadrante");
            }
             else if (x < 0 && y>0)
            {
                Console.Write("punto en el cuarto cuadrante");
            }
            else 
            {
                Console.Write(" punto de origen");
            }

            
             
                
            
            
            

            
            

        }
    }
}