// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i, j] + " | ");
        }
        Console.WriteLine();
    }
}
int[,] GetResultArray(int rows, int columns, int[,] array, int[,]array1)
{
   int[,] matrix = new int[rows, columns];
   
   for(int i = 0; i < array.GetLength(0); i ++)
   {    
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            
            matrix[i, j] = array[i, j] * array1[i, j];
        }
    }   
        return matrix;
}
const int rows = 2;
const int columns = 2;
const int leftRange = 0;
const int rightRange = 9;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
int[,] array1 = GetRandomMatrix(rows, columns, leftRange, rightRange);
int[,] resultArray = GetResultArray(rows, columns, array, array1);
PrintMatrix(array);
Console.WriteLine();
PrintMatrix(array1);
Console.WriteLine("Ниже результат перемножения двух матриц");
PrintMatrix(resultArray);
