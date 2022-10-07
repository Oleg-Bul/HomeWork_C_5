// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


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
int searchX = ReadData("Ввведите координату Х ");
int searchY = ReadData("Введите координату Y ");
void SearchXY(int[,]matrix,int searchX,int searchXY)
{
    if(searchX > matrix.GetLength(1)-1 || searchY >matrix.GetLength(0)-1) 
            Console.WriteLine("Такого элемента нет");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(searchY == i && searchX == j)
            Console.WriteLine("Значение элемента: " + matrix[i,j]);
            
        }
    }
}
FillArray(matrix);
PrintArray(matrix);
SearchXY(matrix,searchX,searchY);
