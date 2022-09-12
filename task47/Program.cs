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
