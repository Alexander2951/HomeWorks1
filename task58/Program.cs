Console.WriteLine("Задайте количество строк матрицы А");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество колонок матрицы А");
int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте минимум диапазона");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Задайте максимум диапазона");
//int y = Convert.ToInt32(Console.ReadLine());
int[,] Matrix(int x,int y)
{
    int[,] table=new int[x,y];
    for (int i=0;i<table.GetLength(0);i++)
    {
        for(int j=0;j<table.GetLength(1);j++)
        {
            table[i,j]=new Random().Next(0,5);
            Console.Write ($"{table[i,j]} \t");
        }
        Console.WriteLine();
    }
    return table;
}
Console.WriteLine();
int[,] A= Matrix(x,y);
Console.WriteLine();
int[,] B= Matrix(y,x);
Console.WriteLine("Произведение матриц");
int[,] C= new int[x,x];
for(int i=0; i<x; i++)
{
    for (int j=0; j<x; j++)
    {
        int sum=0;
        for (int n = 0; n < x; n++)
        {
            int prod=A[i,n]*B[n,j];
            sum=sum+prod;
        }
        C[i,j]=sum;
        Console.Write($"{C[i,j]} \t");
    }
    Console.WriteLine();
}