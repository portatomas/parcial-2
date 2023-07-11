namespace ejercicio_44_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int sumanumeros = 0;
            int numerosingresados;
            while (contador < 5)
            {
                Console.Write($"ingrese el {contador + 1} valor a sumar: ");
                var numeroingresado = int.Parse(Console.ReadLine());
                sumanumeros += numeroingresado;
                contador++;

            }
            Console.WriteLine($"la suma de los cinco numeros es {sumanumeros}");
        }
    }
}
