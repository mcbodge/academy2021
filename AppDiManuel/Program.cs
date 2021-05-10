using AppDiManuel.Converters;
using System;

namespace AppDiManuel
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = '\n';
            char backSlash = '\\';

            string myString1 = "Barbra \"Streisand\"";

            Console.WriteLine(myString1);

            string myString2 = @"http:t         



ww""w.alt
                                itudo.com";

            if(myString1 == myString2) 
            {
                // yep
            }

            Human barbra = new Human("Barbra", "Streisand");

            Console.WriteLine("Name = " + barbra.Name + " Surname = " + barbra.Surname);
            Console.WriteLine($"Name = {barbra.Name} Surname = {barbra.Surname}");

            char[] vowels = new char[5];

            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }






            //Point a = null;//new Point();

            //a = (a != null) ? new Point(7, 0) : new Point(0, 0);

            //if (a != null)
            //{
            //    a = new Point(7,0);
            //}
            //else
            //{
            //    a = new Point(0,0);
            //}

            //if (a != null && a.X == 7)
            //{
            //    Console.WriteLine("X is 7");
            //}
            //;
            ///*
            // Equal 7/9
            // Equal 9/9
            // N/Equal 7/9
            // N/Equal 9/9
            //*/

            //int x = 10;
            //int y = 20;

            //if (x <= y)
            //{
            //    Console.WriteLine("y is bigger (or equals)");
            //}














            ////Point p1 = null;

            ////if(p1 == null)
            ////{
            ////    p1 = new Point();
            ////}

            ////if(p1 != null)
            ////{
            ////    p1.X = 7;
            ////}

            ////Point p2 = p1;

            ////Console.WriteLine(p1.X); // 
            ////Console.WriteLine(p2.X); // 

            ////p1.X = 9;

            ////Console.WriteLine(p1.X); // 
            ////Console.WriteLine(p2.X); // 


























            //int x = 360;
            //x = 10 * 60;
            //int y = 3500 / 10;

            //string myMessage = "Riprendiamo alle 17:10";

            //string myUpperMessage = myMessage.ToUpper();

            //bool isFriday = true;
            bool isSunday = false;

            if (isSunday)
            {
                Console.WriteLine("Is sunday!");
            }

            //Console.WriteLine(myUpperMessage);

            //UnitConverter hoursToMinutes = new UnitConverter(60);

            //int hours = 2;


            //UnitConverter yearsToDays = new UnitConverter(365);

            //int minutes = hoursToMinutes.Convert(hours);

            //Console.WriteLine(hours + " hours = " + minutes + " minutes");

            //int populationA = Human.Population;
            //Human lorenzoS = new Human("Lorenzo", "Siano");
            //int populationB = Human.Population;
            //Human tommaso = new Human("Tommaso", "Totaro");
            //int populationC = Human.Population;
            //Human aleandro = new Human("Aleandro", "Daniel");
            //int populationD = Human.Population;
            //Human andrea = new Human("Andrea");
            //int populationE = Human.Population;

            //int pop = Human.Population;

            //string cognome = tommaso.Surname;

            //andrea.Surname = "Cova";

            //int mySmallNumber = int.MaxValue;

            //long myBigNumber = long.MaxValue -568;

            //int anotherSmallNumber = (int)myBigNumber;

            Console.ReadKey();
        }

        public int GetMaximum(int x, int y)
        {
            // (CONDITION) ? CASE TRUE : CASE FALSE;
            return x > y ? x : y;
        }
    }


}
