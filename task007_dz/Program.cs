// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Main()
{
    Console.Clear();
    Console.WriteLine($"Ведите число b1:");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Ведите число k1:");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Ведите число b2:");
    double b2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Ведите число k2:");
    double k2 = double.Parse(Console.ReadLine()!);
    CrossPoint(b1, k1, b2, k2);
}
void CrossPoint(double b1, double k1, double b2, double k2)
{
    if (b1 == b2 && k1 == k2)
    {
        Console.WriteLine("Прямые не пересекаются!!!");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Точка пересечения x = {x} y = {y}");
    }
}
Main();