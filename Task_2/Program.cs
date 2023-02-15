// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double InterPoint(double b1, double k1, double b2, double k2)
{
    double a = b2 - b1;
    Console.WriteLine(a);
    double b = k1 - k2;
    Console.WriteLine(b);

    double x = a / b;
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения {x}, {y}");
    return y;
}
InterPoint(b1, k1, b2, k2);