// 41: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 
//ввел пользователь.

int [] GetArray (int M, int minValue, int maxValue)
{
    int[] result = new int [M];
    for (int i = 0; i < M; i++)
    {
      result[i] = new Random().Next(minValue, maxValue+1); 
    }
    return result;
}
String ArrayToString(int[] array)
{
    return "[" + String.Join(" ,", array) + "]";  // красиво выводим
}
int CountSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >0) sum++;
    }
    return sum;
}
Console.Write("Задайте значение М: ");
int m = int.Parse(Console.ReadLine()!);
int[] MyArray = GetArray(m, -100, 100);
int sum1 = CountSum(MyArray);
Console.WriteLine(ArrayToString(MyArray));
Console.WriteLine($"Количество чисел больше нуля: {sum1}");