/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] InitArray(int m, int n)
{
    int [,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }

    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SearchAverageArithmetic(int [,] array)
{
    double averageArithmetic = new double();
    double temp = new double();

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            temp += array[i, j]; 
        }
        averageArithmetic = Math.Round(temp / array.GetLength(0), 1);
        Console.WriteLine($"Среднее арифмитическое столбца под номером {j + 1} = {averageArithmetic}");
        temp = 0;
    }
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);;
SearchAverageArithmetic(array);