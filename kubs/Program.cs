// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int q = 1;
while (q <= n)
{
    Console.WriteLine(Math.Pow(q,3));
    q++;
}