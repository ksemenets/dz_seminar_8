// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
const int rows = 5;
const int columns = 6;
const int leftRange = 10;
const int rightRange = 99;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);

int[,] GetSortedMatrix(int[,] array)
{
   int temp = 0;
   for(int i = 0; i < array.GetLength(0); i ++)
   {
        for(int j = 0; j < array.GetLength(1) - 1; j ++)
        {
            for(int g = j + 1; g < array.GetLength(1); g ++) 
            {    
                if(array[i, j] < array[i, g])
                  { 
                     temp = array[i, j];
                     array[i, j] = array[i, g];
                     array[i, g] = temp;
                  }
            }
        }
   } 
   return array;
}
 int[,] sortarray = GetSortedMatrix(array);
 Console.WriteLine();
 PrintMatrix(sortarray);