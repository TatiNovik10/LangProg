//Задача 29: Напишите программу, которая задаёт массив из 8
//элементов и выводит их на экран.(элементы массива вводятся вручную)

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
} 
Console.WriteLine("Введите элементы массива:");
int[] array = new int[8];
FillArray(array);
Console.WriteLine(String.Join(",", array));