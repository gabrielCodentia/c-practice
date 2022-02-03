namespace heyYou
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello World!");
            Interrogation();
        }

        public static Object TitleCase(string word) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word);

        public static void Interrogation()
        {
            Dictionary<int, string> questions = new Dictionary<int, string>();
            questions.Add(1, "Are you having a good day?");
            questions.Add(2, "Do you have pets?");
            questions.Add(3, "Have you traveled to another country?");
            questions.Add(4, "Do you know how to code?");

            int randomQuestionsKey = new Random().Next(1, questions.Count + 1);
            Console.Out.WriteLine("What's your name?");
            string name = Console.ReadLine();
            //include answer and make sure the name starts with capital letter
            Console.Out.WriteLine("Hello {0}!", TitleCase(name));
            Console.Out.WriteLine(questions[randomQuestionsKey]);

            string answer = TitleCase(Console.ReadLine()).ToString();

            switch (randomQuestionsKey)
            {
               case 1:
                 Console.WriteLine(answer == "yes" ? "That's wonderful" : "Sorry to hear that");
               break;
               case 2:
                  Console.WriteLine(answer == "yes" ? "I have one too" : "That's a shame");
               break;
               case 3:
                  Console.WriteLine(answer == "yes" ? "You can call yourself a traveler" : "You should");
               break;
               case 4:
                  Console.WriteLine(answer == "yes" ? "Glad to know that" : "Give it a go");
               break;
            }

        }
    }
}
