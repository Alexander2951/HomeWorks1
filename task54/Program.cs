//Console.WriteLine("Задайте количество строк");
//int str = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте количество колонок");
//int column = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте минимум диапазона");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте максимум диапазона");
//int y = Convert.ToInt32(Console.ReadLine());
int[,] table=new int[5,5];
for (int i=0;i<table.GetLength(0);i++)
{
    for(int j=0;j<table.GetLength(1);j++)
    {
        table[i,j]=new Random().Next(0,25);
        Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("После сортировки");
void Resorting(int str)
{
    for(int i=0; i<table.GetLength(1);i++)
    {
        int min = i;
        for (int j=i+1;j<table.GetLength(1);j++)
        {
            if (table[str,j]>table[str,i]) 
            {
            min=j;
            int temp = table[str,i];
            table[str,i]=table[str,min];
            table[str,min]=temp;
            }
        }        
    }
    

}
for (int i=0;i<table.GetLength(0);i++) Resorting(i);
for (int i=0;i<table.GetLength(0);i++)
{
    for(int j=0;j<table.GetLength(1);j++)
    {
         Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}    