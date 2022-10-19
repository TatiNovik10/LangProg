//Задача 13: Напишите программу, которая выводит
//третью цифру (справа налево) заданного числа или
//сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
if (x <100)
    Console.WriteLine("Такой цифры нет.");
else 
{
 int result = (x/100)%10;
 Console.WriteLine($"Третье число {result}");
}    