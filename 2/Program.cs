// Задайте двумерный массив. Найдите элементы у кот оба индекса четные,
// и замените эти элементы на их квадраты.


int m = 5;
int n = 5;
int [,] array = Array (m, n); 
PrintArray(array);   // сначало печатает массив с рандом числами

for (int i = 1; i < m; i++) // возведение элементов в квадрат
{
    for (int j = 1; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)  // проверка на чет нечет индекса
        {
            array[i, j] *= array[i, j]; // возведение в квадрат 
        }
    }
}
System.Console.WriteLine("Готовый вариант");
PrintArray(array);  // потом печатает уже готовый вариант с возведением в квадрат

int[,] Array (int m, int n)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(1, 10);
        }
    }
    return result;    
}
void PrintArray (int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) ; j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

