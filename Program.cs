using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = person1.askQuestion("What is your cool, first name?");
            Console.Clear();
            person1.lastName = person1.askQuestion("What is your last name?");
            Console.Clear();
            person1.favoriteAnimal = person1.askQuestion("What is your favorite animal?");
            Console.Clear();
            person1.favenum = person1.askfaveNumberQuestion("What is your favorite number?");
            Console.Clear();
            person1.WisdomScore = person1.askNumberQuestion("From 1 to 100, What is your wisdom score?");
            Console.Clear();

            Console.WriteLine($"Hello, {person1.firstName} {person1.lastName}!");
            Console.WriteLine($"Your favorite animal is {person1.favoriteAnimal} and your favorite number is:");
            if (person1.favenum < 5)
            {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(person1.favenum);
                    Console.ResetColor();

            }
                else if (person1.favenum > 10)
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(person1.favenum);
                    Console.ResetColor();
            }

            Console.WriteLine($"You have a wisdom score of {person1.WisdomScore}.That's nice.");
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteAnimal { get; set; } 
        public int favenum { get; set; }

        public int WisdomScore { get; set; }

        public string askQuestion(string question)
        {
            Console.WriteLine($"{firstName}, I gotta ask you something!");
            Console.WriteLine(question);
            return Console.ReadLine();

        }
        public int askNumberQuestion(string question)
        {
            string answer = askQuestion(question);
            return int.Parse(answer);

        }

        public int askfaveNumberQuestion(string question)
        {
            string answer = askQuestion(question);
            return int.Parse(answer);

        }



    }
}
