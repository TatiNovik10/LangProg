//Задача 23: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
static string getPows(int N)
{
    string result = "";
    for (int i = 1; i < N; i++)
    {
        result += (i * i * i).ToString() + ", ";
    }
    result += (N * N * N).ToString();
    return result;
}
Console.Write("Введите N:");
int n = int.Parse(Console.ReadLine());


Console.WriteLine($"{n} cubes {getPows(n)}");



