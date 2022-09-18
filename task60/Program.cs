try
{
    Console.WriteLine("Задайте количество строк");
    int str = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте количество колонок");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте  глубину");
    int layer = Convert.ToInt32(Console.ReadLine());
    void Box(int x, int y, int z)
    {
        int[,,] box = new int[x, y, z];
        int num = 10;
        for (int i = 0; i < z; i++)
        {
            for (int n = 0; n < y; n++)
            {
                for (int m = 0; m < x; m++)
                {
                    box[m, n, i] = num;
                    num++;
                    Console.Write($"{box[m, n, i]} ({m},{n},{i}) \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    Box(str, column, layer);
}
catch
{
    Console.WriteLine("Только числовые значения");
    throw;
}
