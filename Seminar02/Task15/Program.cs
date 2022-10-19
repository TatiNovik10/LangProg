//Задача 15: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным
Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 6 || num > 7)
    Console.WriteLine("Не выходной =(");
else
{
    Console.WriteLine("Это выходной!");
}
