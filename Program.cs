using System;
using System.Collections.Generic;  //kopierade in för säkerhets skull 

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        public static List<People> contactList = new List<People>();
        static void Main(string[] args)
        {
            while (true) // okej, kan bytas ut senare mot en annan variabel...
            {
                
                Menu menu = new Menu();  // kalla på menyklassen

                menu.RunMenu(contactList); //anropa startmetoden som ska använda sig av listan med kontakter
            }

            Console.ReadKey();  // för att hålla uppe konsollrutan, ................ta bort?
        }
    }
}

