//Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 
//Реализовать функцию возведения в степень самостоятельно!
Console.Write("Введите A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;
for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine($"А в степени В равно:{result}");

