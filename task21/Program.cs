void Distance(double x, double y, double z, double x1, double y1, double z1)

{
    double a = (x - x1);
    double b = (y - y1);
    double c = (z - z1);
    double distance = Math.Sqrt((a * a) + (b * b) + (c * c));
    Console.WriteLine($"Расстояние = {distance} ");
}

Console.WriteLine("Если хотите узнать расстояние между двумя точками,задайте координаты этих точек:");

Console.WriteLine("Координаты 1 точки:");
Console.Write("Х = ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Y = ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Координаты 2 точки:");
Console.Write("Х = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z = ");
double z1 = Convert.ToDouble(Console.ReadLine());


Distance(x, y, z, x1, y1, z1);
Console.WriteLine();