// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    int numSum = 0;
    while (n>0)
    {
    numSum = n%10 + numSum;
    n = n/10;
    }
    Console.WriteLine(numSum);
}
catch 
    {
    Console.WriteLine ("Допустимо вводить только цифры");
    }