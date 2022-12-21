// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j] + " "}");
        }
        Console.WriteLine();
    }
}

void FillArrayRandomDoubleNum(double[,] arr1)
{
    Random rnd = new Random();
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i, j] = rnd.Next(-2, 5) + Math.Round(rnd.NextDouble(), 2);
        }
    }
}

Random rnd = new Random();
int rows = rnd.Next(2, 6);
int colums = rnd.Next(2, 6);
double[,] array = new double[rows, colums];

FillArrayRandomDoubleNum(array);
PrintArray(array);