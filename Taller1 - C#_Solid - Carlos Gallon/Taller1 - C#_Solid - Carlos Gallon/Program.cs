using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cadena: ");
        string cadena = Console.ReadLine();

        Console.Write("Ingrese el tamaño: ");
        int tamaño = int.Parse(Console.ReadLine());

        Console.WriteLine($"Combinaciones de {cadena} con tamaño {tamaño}:");

        GenerarCombinaciones(cadena, tamaño, "");
    }

    static void GenerarCombinaciones(string cadena, int tamaño, string combinacionActual)
    {
        if (tamaño == 0)
        {
            // Se ha alcanzado el tamaño deseado, imprimir la combinación actual
            Console.WriteLine(combinacionActual);
            return;
        }

        for (int i = 0; i < cadena.Length; i++)
        {
            // Tomar un carácter de la cadena
            char caracter = cadena[i];

            // Generar combinaciones recursivamente con el resto de la cadena
            GenerarCombinaciones(cadena.Remove(i, 1), tamaño - 1, combinacionActual + caracter);
        }
    }
}
