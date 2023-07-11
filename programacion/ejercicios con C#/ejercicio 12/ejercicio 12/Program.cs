namespace ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tiempo, velocidad, distancia;
            Console.Write(" ingrese la velocidad en m/s " );
            velocidad=double.Parse(Console.ReadLine());
            Console.Write(" ingresa el tiempo en segundos " );
            tiempo=double.Parse(Console.ReadLine());
            distancia = velocidad * tiempo;
            Console.WriteLine(  $"la distancia recorrida x el movil es: ", distancia, "metros");
        }
    }
}