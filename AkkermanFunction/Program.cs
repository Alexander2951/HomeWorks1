try
{
int AF(int m, int n)
    {
        if (m == 0) return n + 1;
        if ((m > 0) && (n == 0)) return AF(m - 1, 1);
        if ((m > 0) && (n > 0)) return AF(m - 1, AF(m, n - 1));
        return n + 1;
    }
Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AF(m, n));
}
catch {Console.WriteLine("'m' и 'n' не должны быть меньше '0'");}