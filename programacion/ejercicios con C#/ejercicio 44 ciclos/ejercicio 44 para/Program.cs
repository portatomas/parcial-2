namespace ejercicio_44_para
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int sumanumeros = 0;
            int numerosingresados;
            for (int contador = 0; contador < 5; contador++)

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