using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = person1.askQuestion("What is your cool, first name?");
            person1.lastName = person1.askQuestion("What is your last name?");
            person1.favoriteAnimal = person1.askQuestion("What is your favorite animal?");
            person1.age = person1.askNumberQuestion("What is your age?");
            person1.WisdomScore = person1.askNumberQuestion("From 1 to 100, What is your wisdom score?");

            Console.WriteLine($"Your first name is {person1.firstName} and your last name is {person1.lastName}. /n Your favorite animal is {person1.favoriteAnimal} and you are {person1.age} years old. /n You have a wisdom score of {person1.WisdomScore}.That's nice.");
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteAnimal { get; set; } 
        public int age { get; set; }
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
    
    }
}
