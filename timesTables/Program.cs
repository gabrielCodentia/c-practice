using System;

namespace timesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 12; j++)
                {
                    Console.Out.WriteLine($"{i} * {j} = {i * j}");
                }
            }
        }
    }
}
