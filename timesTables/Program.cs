using System;
using System.Globalization;

namespace timesTables
{
    class Program
    {
        static void Main(string[] args)
        {
           TimesTable();
           AskAgain();
        }

        static void TimesTable()
        {
            Console.Out.WriteLine("Which times table you want at the start?");
            string userAnswer = Console.ReadLine();
            int number;
            bool success = int.TryParse(userInput, out number);
            if(!success)
            {
                return;
            }
            else
            {
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

        static void AskAgain()
        {
            Console.Out.WriteLine("Would you like to see another one?(Yes/No)");
            string secondUserAnswer = Console.ReadLine();
            string capitalizedAnswer = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secondUserAnswer);
            if (capitalizedAnswer == "Yes"){
                TimesTable();
            }
        }
    }
}
