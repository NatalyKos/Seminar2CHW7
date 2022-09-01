// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of columns: ");

int[,] matr = FillMatrix(m, n, -10, 10);
PrintMatrix(matr);
int findM = ReadInt("Enter the row: ");
int findN = ReadInt("Enter the column: ");
FindElement(matr, findM, findN);

void FindElement(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == rows && j == columns)
            {
                Console.WriteLine($"The element is {matrix[i, j]}");
            }

        }
        if (rows > matrix.GetLength(0) || columns > matrix.GetLength(1))
        {

        }
    }
    Console.WriteLine("No such element");
}

int[,] FillMatrix(int rows, int columns, int left, int right)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rand.Next(left, right);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

