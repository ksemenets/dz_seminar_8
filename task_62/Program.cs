// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[ , ] matrix = new int [4, 4];
 int count = 01; 

    for(int j = 0; j < 4 ; j ++)//1-4
    {
        matrix[0, j] = count;
        count ++;
    }    
    for(int i = 1; i < 4; i ++) //5-7
    {
        matrix[i, 3] = count;
        count ++;
    }
        for(int j = 2; j >= 0 ; j --)//07-10
    {
        matrix[3, j] = count;
        count ++;
    }    
     for(int i = 2; i >= 1; i --) //10-12
    {
        matrix[i, 0] = count;
        count ++;
    }    
        for(int j = 1; j <= 2 ; j ++)//13-14
    {
        matrix[1, j] = count;
        count ++;
    }
         for(int j = 2; j >=1; j --)
    {
        matrix[2, j] = count;
        count ++;
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
    PrintMatrix(matrix);
// НАВЕРНЯКА, ЭТО НЕ ТО РЕШЕНИЕ, КОТОРОЕ ОЖИДАЛОСЬ.
// НО Я, К СВОЕМУ РАЗОЧАРОВАНИЮ, НЕ СМОГ САМОСТОЯТЕЛЬНО 
// ПРОСЧИТАТЬ ЕЁ ТАК ГЛУБОКО. НАБИРАЯ ЭТОТ КОД, ПЫТАЛСЯ НАЙТИ КАКИЕ-ТО ВАРИАНТЫ,
// НО МОЙ МОЗГ ОКАЗАЛСЯ НЕ ГОТОВ. В ИНТЕРНЕТе ТОЖЕ НЕ НАШЕЛ КАКИХ-ТО ВНЯТНЫХ ПОДСКАЗОК.
// В ИТОГЕ ИЗ ГРУППЫ ДАЛИ РЕШЕНИЕ, НО ВЫКЛАДЫВАТЬ ЕГО, КАК СВОЕ, ЧОТ НЕ ХОЧЕТСЯ. 