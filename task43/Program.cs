// See https://aka.ms/new-console-template for more information
string Cross (double kx1,double bx1,double kx2,double bx2)
{
    double x= (bx2-bx1)/(kx1-kx2);
    double y= x*kx1+bx1;
    string cross=($"Точка пересечения прямых находится в координатах x={x}, y={y}");
    return (cross);
}
Console.WriteLine("Введите коэффициент при x первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите смещение b первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент при x второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите смещение b второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Точка пересечения прямых находится по координатам" + Cross(k1,b1,k2,b2));