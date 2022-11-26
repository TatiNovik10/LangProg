// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1*x+b1, y = k2*x+b2; значения b1 k1 k2 задаются пользователем.
//( прямые могут быть параллельными. исп. массивы б1 и к1, б2 и к2. )

double[,] coord = new double[2, 2];
double[] crossPoint = new double[2];
void Get_i_j()
{
    for (int i = 0; i < coord.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициеты {i + 1}-го уравнения (y = k*x +b):\n");
        for (int j = 0; j < coord.GetLength(i); j++)
        {
            if (j == 0) Console.Write($"k= ");
            else Console.Write($"b= ");
            coord[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
double[] Decision(double[,] coord)
{
    crossPoint[0] = (coord[1, 1] - coord[0, 1]) / (coord[0, 0] - coord[1, 0]);
    crossPoint[1] = crossPoint[0] * coord[0, 0] + coord[0, 1];
    return crossPoint;
}
void Condition (double[,] coord)
{
    if (coord[0, 0]== coord[1, 0] && coord[0, 1]==coord[1, 1])
    {
        Console.Write("Прямые совпадают.");
    }
    else if (coord[0, 0] == coord[1, 0] && coord[0, 1] != coord[1, 1])
    {
        Console.Write("Прямые параллельны.");
    }
    else
    {
        Decision(coord);
        Console.Write($"Точка пересечения прямых ({crossPoint[0]}; {crossPoint[1]})");
    }
}
Get_i_j();
Condition(coord);