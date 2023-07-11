using System.ComponentModel.Design;

namespace ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroingresado;
            double num;
            Console.Write("ingrese un numero del 1 al 12 " ); 
            numeroingresado=double.Parse(Console.ReadLine());
            if (numeroingresado>=1 && numeroingresado<=12)
            {
                string mes = convertiroames(numeroingresado);
                Console.WriteLine($"{numeroingresado}equivale {mes}");
                string dias=convertirnumadias(numeroingresado);
                Console.WriteLine($"{numeroingresado}equivale {dias}");
            }
            else
            {
                Console.WriteLine("numero fuera de lo permitido");
            }
            }
        
       
        


        private static string convertirnumadias(double numeroingresado)
        {
            string mes = "";
            string dias = "";
            switch (numeroingresado)
            {
                case 1:
                    mes = "enero y tiene 31 dias";
                    break;
                case 2:
                    mes = "febrero y tiene 28 dias";
                    break;
                case 3:
                    mes = "marzo y  tiene 31 dias";
                    break;
                case 4:
                    mes = "abril y tiene 30 dias";
                    break;
                case 5:
                    mes = "mayo y tiene 31 dias";
                    break;
                case 6:
                    mes = " junio y tiene 30 dias";
                    break;
                case 7:
                    mes = "julio y tiene 31 dias";
                    break;
                case 8:
                    mes = "agosto y tiene 31 dias";
                    break;


                case 9:
                    mes = "septiembre y tiene 30 dias";
                    break;
                case 10:
                    mes = "octubre y tiene 31 dias";
                    break;
                case 11:
                    mes = "noviembre y  tiene 30 dias";
                    break;
                default:
                    mes = "diciembre y tiene 31 dias";
                    break;


            }
            return mes;
        }

        private static string convertiroames(double numeroingresado)
         
        {
            string mes = "";
            switch (numeroingresado)
            {
                case 1:
                    mes = "enero";
                    break;
                case 2:
                    mes = "febrero";
                    break;
                case 3:
                    mes = "marzo";
                    break;
                case 4:
                    mes = "abril";
                    break;
                case 5:
                    mes = "mayo";
                    break;
                case 6:
                    mes = "junio";
                    break;
                case 7:
                    mes = "julio";
                    break;
                case 8:
                    mes = "agosto";
                    break;


                case 9:
                    mes = "septiembre";
                    break;
                case 10:
                    mes = "octubre";
                    break;
                case 11:
                    mes = "noviembre";
                    break;
                default:
                    mes = "diciembre";
                    break;


            }
            return mes;

        }
    }
    }
