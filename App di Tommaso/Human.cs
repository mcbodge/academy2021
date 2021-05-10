using System;


namespace App_di_Tommaso
{


    public class Human
    {
        public string Name { get; private set; }  //"incapsulamento" la roba in {} è una proprietà che serve a permettere di ottenere (get) ma non modiifcare (private set )
        public string Surname { get; private set; }
        public DateTime BirthDate { get; private set; }
        public static int Population { get; private set; } //
        
        

        //public int Age;


        public void SayHi()
        {
            Console.WriteLine("Hi, Im" + Name + "!");
        }
        public Human(string name, string surname) //costruttore
        {
            Name = name;
            Surname = surname;
            BirthDate = DateTime.Now;  //date e ora attuale così quando fa nascere l'essere umano quella è la sua data di nascita
            Population = Population + 1;


        }

        public string Eat(string food)
        {
            return Name + "ate" + food;

            //Console.WriteLine(Nmae + ....) ed invece di string ci voleva il void che a quel punto non vuole il return
      
        
        }
        public static bool UseUmbrella(bool isRainy, bool isVerySunny, bool isWindy)
        {

            return !isWindy && (isRainy || isVerySunny);

        }


    }

}

