using System;

namespace AppDiManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 360;
            x = 10 * 60;
            int y = 3500 / 10;

            string myMessage = "Riprendiamo alle 17:10";

            string myUpperMessage = myMessage.ToUpper();

            bool isFriday = true;
            bool isSunday = false;

            if (isSunday)
            {
                Console.WriteLine("Is sunday!");
            }

            Console.WriteLine(myUpperMessage);
            Console.ReadKey();
        }
    }

    public class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public void SayHi()
        {
            Console.WriteLine(GetMessage());
        }

        public string GetMessage()
        {
            return "Hi, I'm " + Name + "!";
        }
    }
}
