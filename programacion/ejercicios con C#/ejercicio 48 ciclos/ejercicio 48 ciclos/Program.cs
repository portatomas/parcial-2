namespace ejercicio_48_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sumar numeros generados al azar");
            int sumanumeros = 0;
            int cantidadnumeros = 0;
            int numerogenerado;
            Random r = new Random();  // genera numeros ala azar

            do
            {
                var nroazar = r.Next(1, 101); // genera numeros entre 1 y 101
                Console.WriteLine($"{cantidadnumeros}° numero generado igual a {nroazar}");
                cantidadnumeros++;
                sumanumeros += nroazar;
                if (sumanumeros > 200)
                {
                    break;
                }
                
            }while (true);
            Console.WriteLine($"se generadon {cantidadnumeros} numeros al azar");
            Console.WriteLine($" su suma es {sumanumeros}");
        }
    }
}