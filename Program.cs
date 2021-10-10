using System;
using System.Collections.Generic;  //kopierade in för säkerhets skull 

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();
            Menu menu = new Menu();

            while (true) // okej, kan bytas ut senare mot en annan variabel...
            {
                menu.RunMenu(contactList); //anropa startmetoden som ska använda sig av listan med kontakter
            }

            Console.ReadKey();  // för att hålla uppe konsollrutan, ................ta bort?
        }
    }
}

