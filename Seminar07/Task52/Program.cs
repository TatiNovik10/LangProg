// Задача 52: задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце. (ср. ар = сумма, деленная на кол-во).
int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t"); 
        }
        Console.WriteLine();
    }
}
void ArithmeticMean( int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       int sum = 0;
       for (int i = 0; i < array.GetLength(0); i++)
       {
        sum += array[i, j];
       } 
       sum/= array.GetLength(0);
       Console.Write($"{sum, 5} ");
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] myArray = GetArray(rows, cols, 0, 10);
Console.WriteLine();
PrintArray(myArray);
Console.WriteLine("Среднее арифметическое столбцов");
ArithmeticMean(myArray);

