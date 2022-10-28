//Задача 21: Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
double lineLen(int[] A, int[] B)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2)), 2);
    return result;
}
int[] a = new int[3];
int[] b = new int[3];
Console.Write("Координата X для точки А: ");
a[0] = int.Parse(Console.ReadLine()!);
Console.Write("Координата Y для точки А: ");
a[1] = int.Parse(Console.ReadLine()!);
Console.Write("Координата Z для точки А: ");
a[2] = int.Parse(Console.ReadLine()!);
Console.Write("Координата X для точки В: ");
b[0] = int.Parse(Console.ReadLine()!);
Console.Write("Координата Y для точки В: ");
b[1] = int.Parse(Console.ReadLine()!);
Console.Write("Координата Z для точки В: ");
b[2] = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Расстояние между точками А и В равно: {lineLen(a, b)}");
