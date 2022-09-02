// See https://aka.ms/new-console-template for more information
int[] n = new int[8];
for (int i = 0; i < 8; i++)
    {
    n[i] = new Random().Next(1,50);
    }
void data (int a, int b)
{
    for (int i = a; i<=b; i++)  Console.Write($"{n[i]}, ");
}   
data (0,4);
Console.WriteLine();
data (5,7);   
Console.WriteLine();