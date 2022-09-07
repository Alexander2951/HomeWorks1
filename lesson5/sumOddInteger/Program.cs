// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте размер массива (целое неотрицательное число)");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте минимальное число в массиве ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте максимальное число в массиве");
int maxValue =  Convert.ToInt32(Console.ReadLine()) +1;
int [] numbers = new int [n];
for (int i=0; i<n; i++)
{
    numbers[i] = new Random().Next(minValue,maxValue);
}
int sumOddNumbers (int[] numbers)
{
    int sum = 0;
    for(int i=0; i<n; i++)
    {
        if (i%2!=0) sum = sum+numbers[i];
    }
    return sum; 
}
foreach(int i in numbers) Console.Write($"{i}, ");

Console.WriteLine("");
Console.WriteLine ($"Сумма чисел стоящих на нечетных позициях равна" +sumOddNumbers(numbers));