using System;

namespace timesTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Which times table you want at the start?");
            string userInput = Console.ReadLine();
            int number;
            bool success = int.TryParse(userInput, out number);
            if(!success){
                return;
            }
            else {
                for (int i = 0; i <= 12; i++)
                {
                    for (int j = 0; j <= 12; j++)
                    {

                        if (number == j) {
                        Console.Out.WriteLine($"{i} * {j} = {i * j}");

                        }
                    }
                }
            }
        }
    }
}
