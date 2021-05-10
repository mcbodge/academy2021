using System;
using App_di_Tommaso.Converters;


namespace App_di_Tommaso
{
    class Program
    {
        static void Main(string[] args)  //metodo (quindi dentro una classe) speciale usato come punto di partenza per il compilatore
        {


            //int x = 360;
            ////Int32 y = 250; oppure Int64 analogo a long
            ////x = 10*50 così creavo una nuova variabile
            //int y = 12 * 30;

            //string myMessage = "Helloooo";

            //myMessage = myMessage.ToUpper();

            //bool isFriday = true;
            //bool isSunday = false;

            //if (isSunday == false)
            //{
            //    Console.WriteLine("Is not Sunday!");
            //}
            //Console.WriteLine(myMessage);


            /*
            public class Point //ho usato dei tipi esistenti (int) per creare un tipo custom (point)
        {
            public int CoordX;
            public int CoordY;
             
        }

            public class Human
            {
            public string Name;
            public string Surname;
            public int Age;

            public void SayHi()
            {
                Console.WriteLine("Hi, I'm" + Name + "!");
            }



            }
            */

            /*  UnitConverter hoursToMinutes = new UnitConverter(60);*/ // new chiama il costruttore

            //UnitConverter yearsToDays = new UnitConverter(365);

            //int hours = 2;
            //int minutes = hoursToMinutes.Convert(hours);

            //Console.WriteLine(hours + "hours = " + minutes + "minutes" );

            //Human tommaso = new Human("tommaso", "totaro");
            //int populationT = Human.Population;
            //Human lorenzo = new Human("lorenzo", "siano");
            //int populationL = Human.Population;
            //Human aleandro = new Human("aleandro", "daniel");
            //int populationA = Human.Population;

            //Point p1 = new Point();
            //p1.X = 7;
            //Point p2 = p1;


            //Console.WriteLine(p1.X);
            //Console.WriteLine(p2.X);

            //p1.X = 9;

            //Console.WriteLine(p1.X);
            //Console.WriteLine(p2.X);

            //Point a = new Point();
            //a.X = 7;
            //Point b = a;
            //b.X = 9;

            //if(a == b)
            //{
            //    Console.WriteLine("Equal with ab =" + a.X + b.X);
            //}

            //if(a != b)
            //{
            //    Console.WriteLine("NOT Equal with ab =" + a.X + b.X);
            //}


            Point a = null; //new Point();



            //if (a != null )
            //{
            //    a.X = 7;
            //}

            //if (a !=null && a.X == 7) //dato che && è cortocircuitato non viene compilato ciò che sta dopo essendo già falso ciò che è prima sennò veniva l'errore da eccezione
            //{
            //    Console.WriteLine("NOT Equal with ab =" + a.X + b.X);
            //}

            //int x = 10;
            //int y = 20;

            //if(x!>=y)
            //{

            //    Console.WriteLine("x<20");

            //}

            //public int GetMaximum(int x, int y)
            //{ 
            //    return x > y ? x : y;   //
            //}

            char myChar = 'x';  //un sigolo carattere
            char acapo = '\n';  //vai a capo
            char bs = '\\'; // metto due \\ ma ne viene uno \

            string prova = @"http:\\jadhsfi.com"; //così evito di mettere 4 \\\\

            char[] vowels = new char[5]; //array di 5 elementi
            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            

            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }












            Console.ReadKey();  //questo dice leggi un carattere senza far chiudere l'app
        }
    }   
}
