void PrintInterval(int arg1, int arg2)
{
    if (arg1 == arg2)
    {
        Console.WriteLine(arg1);
        return;
    }
    if (arg1 > arg2)
    {
        int temp = arg2; arg2 = arg1; arg1 = temp;
    }
    Console.Write(arg1 + ", "); arg1 = arg1 + 1; PrintInterval(arg1, arg2);
}
Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
PrintInterval(m,n);