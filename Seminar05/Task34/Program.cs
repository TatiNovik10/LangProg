// Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу,
// которая покажет количество четных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}
int GetEvenNum(int[] array)
{
    int countNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            countNum += 1;
        }
    }
    return countNum;
}
int[] array = GetArray(25, 100, 999);
Console.WriteLine(String.Join(" ,", array));
int countNum2 = GetEvenNum(array);
Console.WriteLine($"{countNum2}");