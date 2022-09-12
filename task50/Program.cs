

Console.WriteLine("Задайте количество строк");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество колонок");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимум диапазона");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимум диапазона");
int y = Convert.ToInt32(Console.ReadLine());
int[,] table=new int[str,column];
for (int i=0;i<table.GetLength(0);i++)
{
    for(int j=0;j<table.GetLength(1);j++)
    {
        table[i,j]=new Random().Next(x,y);
        Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки злемента отсчитывая с первого");
int i1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номенр колонки начиная с первой");
int j1 = Convert.ToInt32(Console.ReadLine());
if (i1>0 && i1<str+1)
    {
        if (j1>0 && j1 < column+1) Set(i1,j1);
        else Console.WriteLine("Данная позиция за пределами таблицы");
    }
else Console.WriteLine("Данная позиция за пределами таблицы");
void Set(int str, int column)
{
    Console.WriteLine(table[str-1,column-1]);
}