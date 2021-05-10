using System;

namespace AppDiManuel
{
    public class Human
    {
        public string Name { get; private set; }
        public string Surname { get; set; }

        public Human(string name, string surname)
        {
            Name = name;
            Surname = surname;
            BirthDate = DateTime.Now;
            Population = Population + 1;
        }


        public DateTime BirthDate { get; private set; }
        public static int Population { get; private set; }


        public Human(string name)
        {
            Name = name;
            Surname = "UNKNOWN";
        }

        public void SayHi()
        {
            Console.WriteLine("Hi, I'm " + Name + "!");
        }

        //public string GetMessage()
        //{
        //    return "Hi, I'm " + Name + "!";
        //}

        public void Eat(string food)
        {
            Console.WriteLine(Name + " ate " + food);
        }

        public static bool UseUmbrella(bool isRainy, bool isVeryVerySunny, bool isWindy)
        {
            return !isWindy && (isRainy || isVeryVerySunny);
        }
    }
}
