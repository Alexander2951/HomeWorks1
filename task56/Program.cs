//Console.WriteLine("Задайте количество строк");
//int str = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте количество колонок");
//int column = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте минимум диапазона");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте максимум диапазона");
//int y = Convert.ToInt32(Console.ReadLine());
int[,] table=new int[5,4];
for (int i=0;i<table.GetLength(0);i++)
{
    for(int j=0;j<table.GetLength(1);j++)
    {
        table[i,j]=new Random().Next(0,25);
        Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("Строка с наименьшей суммой ");
int Sum (int str)
{
    int sum=0;
    for (int i=0;i<table.GetLength(1);i++)
    {
        sum=table[str,i]+sum;
    }
    return sum;
}
int FindMin(int[] array)
{
    int min=array[0];
    int minPosition = 0;
    for(int i=1;i<array.Length;i++)
    {
        if(min>array[i])
        {
            min = array[i];
            minPosition = i;
        }
    }
    return minPosition;
}
int[] array=new int[table.GetLength(0)];
for(int i=0; i<array.Length;i++) array[i]=Sum(i);
Console.WriteLine(FindMin(array)+1);