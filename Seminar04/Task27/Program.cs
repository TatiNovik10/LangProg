//Задача 27: Напишите функцию и запустите ее, которая
//принимает на вход число и выдаёт сумму цифр в числе.
int GetSum(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int sum = GetSum(N);
Console.WriteLine($"Сумма цифр числа равна {sum}.");





