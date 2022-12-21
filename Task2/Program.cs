//Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArrayRandomIntNum(int[,] arr1)
{
    Random rnd = new Random();
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            arr1[i, j] = rnd.Next(1, 50);
        }
    }
}

void PrintArray(int[,] arr)
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

int ReadStringCons(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadStringCons("Введите индекс строки: ");
int colums = ReadStringCons("Введите индекс столбца: ");

Random rnd = new Random();

int[,] array = new int[rnd.Next(2,8), rnd.Next(2,8)];

FillArrayRandomIntNum(array);

PrintArray(array);
Console.WriteLine();

if(rows>array.GetLength(0) || (colums>array.GetLength(1)))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine("Элемент с индексом ["+rows+","+colums+"] => " +array[rows,colums]);
}

