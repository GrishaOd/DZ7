/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


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

void FindColumnSum(int[,] matrix, int rownumber)
{
    int columnnumber = 1;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double columnsum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnsum += matrix[i, j];
        }
        double averege = Math.Round((columnsum / matrix.GetLength(0)), 1);
        Console.WriteLine($"Сумма чисел в столбце № {columnnumber} равна {averege} ");
        columnnumber++;
    }
}

FindColumnSum(Matr, a);