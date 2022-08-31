// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координату 'x' первой точки");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату 'y' первой точки");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату 'z' первой точки");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату 'x' второй точки");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату 'y'второй точки");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату 'z' второй точки");
int z2 = int.Parse(Console.ReadLine());
double s = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine(s);