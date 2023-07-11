int mes,dias;
Console.Write("ingrese un numero del 1 al 12");
var numeroingresado=int.Parse(Console.ReadLine());
if (numeroingresado>=1 && numeroingresado <=12) ;
{
    string informardiames = convertirnumeroames(numeroingresado);
    Console.WriteLine($"{numeroingresado} equivale a {"mes"} ");
    string informardiasdelmes = convertirnumeroadias(numeroingresado);
    Console.WriteLine($"{numeroingresado}equivale a {"dias"}");
}


string convertirnumeroadias(int numeroingresado)
{
    string dias = "";
    switch (numeroingresado)
    {
        case 1:
            dias = "31";
            break;
        case 2:
            dias = "28";
                break;
            case 3:
            dias = "30";
            break;
            case 4:
            dias = "30";
            break;
            case 5:
            dias = "31";
            break;
            case 6:
            dias = "30";
            break;
            case 7:
            dias = "31";
            break;
            case 8:
            dias = "31";
            break;
            case 9:
            dias = "30";
            break;
            case 10:
            dias = "31";
            break;
            case 11:
            dias = "30";
            break;
        default:
            dias = "30";
            break;

    }   return dias;

    
}

string convertirnumeroames(int numeroingresado)
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
            mes = " mayo";
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


    } return mes;
        
        



        
        
     

        
} 