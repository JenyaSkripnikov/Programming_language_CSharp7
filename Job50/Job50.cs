/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] InitArray(int m,int n)
{
    Random rnd = new Random();
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(0, 100);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

void SearchNumber(int[,] array)
{
    Console.Write("Введите искомое число в массиве: ");
    int numSearch = Convert.ToInt32(Console.ReadLine());
    int x = -1;
    int y = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == numSearch)
            {
                x = i + 1;
                y = j + 1;
                Console.WriteLine($"Число {numSearch} находится в массиве номер строки {x}, номер столбца {y}.");
            }
            else{}
        }
    }
    if (x == -1 && y == -1)
    {
    Console.Write($"Числа {numSearch} нет в данном массиве.");
    }
    else{}     
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
SearchNumber(array);