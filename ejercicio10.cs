using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Ingrese los valores para una matriz de 3x3:");

        // Paso 1: Llenar la matriz
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Valor en posición [{fila}, {col}]: ");
                matriz[fila, col] = int.Parse(Console.ReadLine());
            }
        }

        // Paso 2: Pedir un número para multiplicar cada fila
        int[] multiplicadores = new int[3];

        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write($"Ingresa el número para multiplicar la fila {fila + 1}: ");
            multiplicadores[fila] = int.Parse(Console.ReadLine());
        }

        // Paso 3: Multiplicar cada fila
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                matriz[fila, col] *= multiplicadores[fila];
            }
        }

        // Paso 4: Mostrar la nueva matriz
        Console.WriteLine("\nMatriz actualizada:");
        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matriz[fila, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}
