// See https://aka.ms/new-console-template for more information


using System.ComponentModel;

Console.WriteLine("Eliga la categoria del hospedaje:        ");
Console.WriteLine("********************************:        ");
Console.WriteLine("3: estrellas:");
Console.WriteLine("5: estrellas:");
int categoria = int.Parse(Console.ReadLine());

float precio = 0f;

Console.WriteLine("Cuandos dias se quedara?:");
float diasquedada =float.Parse(Console.ReadLine());
Console.WriteLine("************************:");


float preciofin = 0f;

switch (categoria)
{
    case 3:
        if (diasquedada <=5)
        {
            precio=100;
            preciofin = (diasquedada * (precio + 7));
            
        }
        else if (diasquedada >=6 || diasquedada <=10)
        {
            precio = 85;
            preciofin = (diasquedada * (precio + 7));

        }
        else if (diasquedada >= 11)
        {

            precio = 70;
            preciofin = (diasquedada * (precio + 7));

        }
        break;

    case 5:
        if (diasquedada <= 5)
        {
            precio = 300;
            preciofin = (diasquedada * (precio + 7));


        }
        else if (diasquedada >= 6 || diasquedada <= 10)
        {
            precio = 270;
            preciofin = (diasquedada * (precio + 7));

        }
        else if (diasquedada >= 11)
        {
            precio = 250;
            preciofin = (diasquedada * (precio + 7));

        }
        break;

    default:
        Console.WriteLine("Esa categoria no existe :,c");
        break;

}
Console.WriteLine("Usted estaria pagando:" + preciofin + "$");
