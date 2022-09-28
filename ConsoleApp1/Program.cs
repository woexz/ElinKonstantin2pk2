namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //for (int i = 20; i < 70; i += 4)
            //{
            //    Console.WriteLine(i);
            //}

            //задание 2
            //char symbol = 'k';
            //string result = "";
            //for (int i = 0; i < 6; i++)
            //{
            //    result += convert.tochar(symbol + i);
            //}
            //console.writeline(result);

            // Задание 3
            //int n = 3;
            //int m = 4;

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write('#');
            //    }
            //    Console.WriteLine();
            //}

            // Задание 4
            //int value = 10;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % value == 0 || i % value == value)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // задание 5
            int i = 4;
            int j = 40;
            int difference = 25;

            for (; ; i++, j--)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
                if (j - i == difference || j - i < difference)
                {
                    Console.WriteLine($"i = {i} \nj = {j}");
                    break;
                }
            }
        }
    }
}