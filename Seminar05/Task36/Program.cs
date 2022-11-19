//36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечетных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int GetSumEl(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
Console.Write("Задайте размер массива: ");
int size1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте начальное значение: ");
int minValue1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте конечное значение массива: ");
int maxValue1 = int.Parse(Console.ReadLine()!);

int[] MyArray = GetArray(size1, minValue1, maxValue1);
Console.WriteLine($"[{String.Join(", ", MyArray)}]");
Console.WriteLine($"Cумма элементов на нечетных позициях:{GetSumEl(MyArray)}");