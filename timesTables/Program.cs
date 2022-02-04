using System;
using System.Globalization;

namespace timesTables
{
    class Program
    {
        static void Main(string[] args)
        {
           TimesTable();
        }

        static void TimesTable()
        {
            Console.Out.WriteLine("Which times table you want at the start?");
            string userAnswer = Console.ReadLine();
            int number;
            bool success = int.TryParse(userAnswer, out number);
            if(!success | number > 12 | number < 0)
            {
                Console.Out.WriteLine("Please use a number between 0 and 12");
                TimesTable();
            }
            else
            {
                for (int i = 0; i <= 12; i++)
                {
                    for (int j = 0; j <= 12; j++)
                    {
                        if (number == j)
                        {
                            Console.Out.WriteLine($"{i} * {j} = {i * j}");
                        }
                    }
                }
                AskAgain();
            }
        }

        static void AskAgain()
        {
            Console.Out.WriteLine("Would you like to see another one?(Yes/No)");
            string secondUserAnswer = Console.ReadLine();
            string capitalizedAnswer = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secondUserAnswer);
            if (capitalizedAnswer == "Yes")
            {
                TimesTable();
            }
            else if (capitalizedAnswer != "No")
            {
              Console.Out.WriteLine("Please type Yes or No");
              AskAgain();
            }

        }
    }
}
