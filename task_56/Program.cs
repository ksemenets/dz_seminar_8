// Задача 56: Задайте двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

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
int[] GetMinRow(int[,] array)
{
   int[] matrix = new int[array.GetLength(0)];
   
   for(int i = 0; i < array.GetLength(0); i ++)
   {    int summa = 0;
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            summa = summa + array[i, j];
            matrix[i] = summa;
        }
    }   
        return matrix;
}
const int rows = 4;
const int columns = 4;
const int leftRange = 0;
const int rightRange = 10;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);
int[] minrow = GetMinRow(array);
 
 int min = minrow[0];
 int indexMin = 0 ;
 for(int i = 0; i < minrow.Length; i ++)
    {
        if(minrow[i] < min)
        { 
            min = minrow[i];
            indexMin = i;
        }
 }
  Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMin + 1}");
