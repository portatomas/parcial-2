namespace ejercicio_44_repetir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int sumanumeros = 0;
            int numerosingresados;
            do
            {
                Console.Write($"ingrese el {contador + 1} valor a sumar: ");
                var numeroingresado = int.Parse(Console.ReadLine());
                sumanumeros += numeroingresado;
                contador++;
            } while (contador < 5);


            Console.WriteLine($"la suma de los cinco numeros es {sumanumeros}");
        }
    }
}