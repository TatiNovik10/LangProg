// Задача 50: Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);// result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void FindNumber(int[,] array)
{
    Console.Write("Введите искомое число: ");
    int number = int.Parse(Console.ReadLine()!);
    int i1 = -1;
    int j1 = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((array[i, j]) == number)
            {
                number = array[i, j];
                i1 = i;
                j1 = j;
            }

        }

    }
    Console.WriteLine();
    Console.WriteLine($"Элемент {number} находится в {i1} строке {j1} столбце");
}
Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);

Console.WriteLine();
FindNumber(array);