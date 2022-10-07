// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int matrX = ReadData("Ввведите размер M ");
int matrY = ReadData("Введите размер N ");
int[,] matrix = new int[matrX, matrY];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
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

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrX; i++)
    {
      for (int j = 0; j < matrY; j++)
        matrix [i,j] = new Random().Next(0,100);
    }
}

void ArithmeticMeanOfTheColumn(int[,]matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;
        double aritMean = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[j,i];
            
        }
        aritMean = sum /(matrix.GetLength(1));
        Console.WriteLine(" Среднее арифметическое столбцa "+ (i+1)+":");
        Console.WriteLine(" "+ Math.Round(aritMean,1));
        
    }
}
FillArray(matrix);
PrintArray(matrix);
ArithmeticMeanOfTheColumn(matrix);
