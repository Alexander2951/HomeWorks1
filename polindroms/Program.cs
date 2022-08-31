Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
if (number[0] == number[4])
    {
        if (number[1] == number[3])
        {
            Console.WriteLine("Это полиндром");
        }
        else Console.WriteLine("Это не полиндром");
    }
else Console.WriteLine("Это не полиндром");