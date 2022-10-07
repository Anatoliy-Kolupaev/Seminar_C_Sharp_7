// Задайте двумерный массив. Найдите сумму элементов, на главной деагонали с индексом (0, 0); (1; 1) и т.д.
// Например: 
// 1 2 6 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12


// double a = GetRandomNumber (11,22);
// double GetRandomNumber(double minimum, double maximum)
// {
//     return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,1);
// }

int rows = 5;
int colums = 5;
int len = rows < colums ? rows : colums; // Условие если строки меньше чем столбцы то сум = строки, иначе сум = столбцы

int [,] FillArray (int rows, int colums) // заполнили массив случайными числами
{
    int [,] result = new int [rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
int Summ (int len, int [,] array) // считает сумму чисел с индексом по деоганали 
{
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

void PrintArray (int [,] inArray) // печать массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int [,] array = FillArray(rows, colums);
PrintArray(array);
System.Console.WriteLine();
int sum = Summ (len, array);
System.Console.WriteLine(sum);