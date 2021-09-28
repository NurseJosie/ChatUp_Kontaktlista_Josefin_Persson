using System;
using System.Collections.Generic;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(); //anropa startmetoden

            List<People> peopleList = new List<People>();
            peopleList.Add(new People());
            


            Console.ReadKey();
        }

        static void Start() //startmetod
        {
            Console.WriteLine("meny");
            Console.WriteLine("1- skapa");
            Console.WriteLine("2- läsa andra profiler");
            Console.WriteLine("3-uppdatera min profil");
            Console.WriteLine("4- ta bort profil");
            Console.WriteLine("5- lista alla");
            Console.WriteLine("6- lista alla som börjar på spec. bokstav");
            string userInput = Console.ReadLine();  //int eller string??

            //switch
            switch (switch_on)
            {
                default:
            }
        }
    }
    }

