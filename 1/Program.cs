// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

System.Console.Write("Введите число m: ");
int m = int.Parse(System.Console.ReadLine());
System.Console.Write("Введите число n: ");
int n = int.Parse(System.Console.ReadLine());

void Array (int m, int n)
{
    int [,] numbers = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers [i, j] = i+j;
            System.Console.Write( numbers [i,j]);
        }
        System.Console.WriteLine();
    }
    
}
Array(m, n);