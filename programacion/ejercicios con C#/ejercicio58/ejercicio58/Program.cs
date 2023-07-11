namespace ejercicio58
{
    Programa de clases internas
    {
        vacío estático principal ( cadena [ ]
        args )
        {
            consola _ WriteLine(" ¡Hola, mundo! ");

            int valorInicial = 0, valorFinal = 0;
            int sumaNumero = 0, cantidadImpares = 0;
            hacer
            {
                consola _ Write(" Ingrese el valor inicial del intervalo: ");
                var str = Consola.Leer Línea();
                if (int.TryParse(str, out valorInicial))
                {
                    romper;
                }
                consola _ WriteLine(" Numero no valido ");

            }
            mientras(verdadero);

            hacer
            {
                consola _ Write(" Ingrese el valor final del intervalo: ");
                var str = Consola.Leer Línea();
                if (int.TryParse(str, out valorFinal))
                {
                    romper;
                }
                consola _ WriteLine(" Numero no valido ");

            }
            mientras(verdadero);
            if (valor Inicial < valor Final )
            {
                for (int numero = valorInicial; numero <= valorFinal; numero++)
                {
                    si(espar(numero))
                    {
                        sumaNumero += numero;
                    }
                    demás
                    {
                        cantidadImpares++;
                    }
                }

            }
            demás
            {
                for (int numero = valor Inicial; numero >= valor Final ; numero-- )
                {
                    si(espar(numero))
                    {
                        sumaNumero += numero;
                    }
                    demás
                    {
                        cantidadImpares++;
                    }
                }

            }
            consola _ WriteLine($" La suma de los pares es {sumaNumero} ");
            consola _ WriteLine($" La cantidad de nros impares es {cantidadImpares} ");
        }
        Bool estático privado EsPar ( int nro )  
        {
            volver nro  % 2 == 0;
        }
    }