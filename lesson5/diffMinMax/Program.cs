// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте размер массива (целое неотрицательное число)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальное число в массиве ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте максимальное число в массиве");
int maxValue = (int.Parse(Console.ReadLine()) + 1);
int [] random = new int[n];
int [] numbers = random;
for (int i = 0; i < n; i++)
{
    numbers[i] = new Random().Next(minValue,maxValue);
}
int min = numbers[0];
        
        for (int i = 0; i<n; i++)
             {
                if (numbers[i] < min) min = numbers[i];
             }
        
    
int max = numbers[0];

                for (int i = 0; i<n; i++)
              {
                if (numbers [i] > max) max = numbers[i];
              }
        
    
void printMassiv(int[] massiv)
{
    Console.Write("[")  ;
    foreach (int i in massiv)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("]");
}
int diff = max-min;

printMassiv(numbers);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива {diff}");