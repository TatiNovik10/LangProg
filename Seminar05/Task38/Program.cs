// Задайте массив вещественных чисел. Найдите разницу  между минимальным и максимальным
// элементами массива.(поиск мин и макс отдельными функциями)
double[] GetArray(int size, int a, int b)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * (b - a) + a, 5);
    }
    return arr;
}
double maxValue(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double minValue (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]< min)
        {
            min = array[i];
        }
    }
    return min;
}
Console.Write("Задайте размер массива: ");
int size1 = int.Parse(Console.ReadLine()!);
Console.Write("Задайте крайнее левое значение:");
int a1 = int.Parse(Console.ReadLine()!);               
Console.Write("Задайте крайнее правое значение:");
int b1 = int.Parse(Console.ReadLine()!);

double[] MyArray = GetArray(size1, a1, b1);
Console.WriteLine($"массив: [{String.Join("," , MyArray)}]");              
Console.WriteLine($"Минимальное значение в массиве: {minValue(MyArray)}");
Console.WriteLine($"Максимальное значение в массиве: {maxValue(MyArray)}");

double result = maxValue(MyArray) - minValue(MyArray);
Console.WriteLine($"Разница между максимальным и минимальным значениями равна: {result}");              

               

               

              