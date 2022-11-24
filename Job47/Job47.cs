/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
Например:
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] InitArray(int m, int n)
{
    Random rnd = new Random();
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Math.Round(rnd.Next(-99, 100) + rnd.NextDouble(), 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = InitArray(m,n);
Console.WriteLine();
PrintMatrix(array);