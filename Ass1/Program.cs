// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = ReadInt("Enter the number of rows: ");
int n = ReadInt("Enter the number of columns: ");

double[,] matr = FillMatrix(m, n, -10.5, 10.5);
PrintMatrix(matr);

double[,] FillMatrix(int rows, int columns, double left, double right)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            
            matrix[i, j] = Math.Round((left + rand.NextDouble()*(right-left)), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
        for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
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
