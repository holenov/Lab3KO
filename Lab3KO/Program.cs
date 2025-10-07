using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        int[,] A = new int[4, 4];

        Console.WriteLine("Введіть елементи матриці A(4x4):");
        InputMatrixFromKeyboard(A);

        Console.WriteLine("\nМатриця A(4x4):");
        PrintMatrix(A);

        Console.WriteLine("\nНегативні елементи на головній діагоналі:");
        PrintNegativeDiagonalElements(A);
    }

    static void InputMatrixFromKeyboard(int[,] A)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"A[{i},{j}] = ");
                A[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    static void PrintMatrix(int[,] A)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{A[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    static void PrintNegativeDiagonalElements(int[,] A)
    {
        bool found = false;
        for (int i = 0; i < 4; i++)
        {
            if (A[i, i] < 0)
            {
                Console.WriteLine($"A[{i},{i}] = {A[i, i]}");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("На головній діагоналі немає негативних елементів.");
    }
}
