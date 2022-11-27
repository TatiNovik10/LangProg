//Задача 47: Задайте двумерный массив размером m x n, 
//заполненный случайными вещественными числами. (с округлением). 
Console.WriteLine("Задайте m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте n:");
int n = int.Parse(Console.ReadLine()!);
double[,] matrix = new double [m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { Console.Write($"{matr[i, j]} "); }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
























