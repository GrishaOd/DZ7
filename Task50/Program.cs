/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
 void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine());

int[,] Matr = new int [a, b];
FillArray(Matr);
PrintArray(Matr);

void FindElement (int rownumber, int columnnumber)
{
if (rownumber <= a && rownumber > 0
    && columnnumber <= b && columnnumber > 0)
    {
        Console.WriteLine("Элемент с такими координатами - " + Matr[rownumber - 1, columnnumber - 1]);
    }
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}
}

Console.Write("Введите номер строки: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = int.Parse(Console.ReadLine());

FindElement(row, column);


