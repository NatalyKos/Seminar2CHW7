// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of columns: ");

int[,] matr = FillMatrix(m, n, 0, 10);
PrintMatrix(matr);
double avg = 0;
FindAverage(matr);

void FindAverage(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum = sum + matrix[j,i];
        }
            avg = sum/m;
            Console.WriteLine(avg);
    }

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