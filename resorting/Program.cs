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
Console.WriteLine();
for(int s=0;s<str*column; s++)
{

    resort(str,column);
    
}
for (int i=0;i<str;i++)
{
    for(int j=0;j<column;j++)
    {
        Console.Write ($"{table[i,j]} \t");
    }
    Console.WriteLine();
}
void resort(int x,int y)

    {
        int maxTable = table[0,0];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if(maxTable<table[i,j])
                {
                    int temp = table[i,j];
                    table[i,j] = maxTable;
                    maxTable = temp;
                }           
            }
            
        }

    }