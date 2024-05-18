using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingresa la cantidad de piezas a procesar:");
        int n = int.Parse(Console.ReadLine());

        int contador = 0;
        int contadorAptas = 0;

        while (contador < n)
        {
            Console.Write($"Ingresa la longitud de la pieza {contador + 1}: ");
            double longitud = double.Parse(Console.ReadLine());

            if (longitud >= 1.20 && longitud <= 1.30)
            {
                contadorAptas++;
            }

            contador++;
        }

        Console.WriteLine($"La cantidad de piezas aptas es: {contadorAptas}");
    }
}

