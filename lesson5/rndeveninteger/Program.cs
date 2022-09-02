// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [n];
for (int i = 0; i<n; i++)
{
    numbers [i] = new Random().Next(100,1000);
    Console.Write($"{numbers[i]}, ");
}
Console.WriteLine();

int cost (int[] arg)
{
    int count = 0; 
for (int i = 0; i<n; i++)
    {  
        
        if (arg[i] % 2 == 0) count++;
    }
    return count;
}
    
Console.WriteLine(cost(numbers));   
