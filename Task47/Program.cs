// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

int matrX = ReadData("Ввведите размер M ");
int matrY = ReadData("Введите размер N ");
double[,] matrix = new double[matrX, matrY];
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}


int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double maximum = 99;
double minimum = -99;
double GetRandomNumber(double minimum, double maximum)
{
    return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,2);
}
void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrX; i++)
    {
      for (int j = 0; j < matrY; j++)
        matrix [i,j] = GetRandomNumber(maximum,minimum);
    }
}
FillArray(matrix);
PrintArray(matrix);
