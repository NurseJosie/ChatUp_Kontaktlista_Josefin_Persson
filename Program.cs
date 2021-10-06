using System;
using System.Collections.Generic;  //kopierade in för säkerhets skull 

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // okej, kan bytas ut senare mot en annan variabel...
            {
                ContactList contactListObject = new ContactList();    //skapa lista med kontakter kallad contactList
                Menu menu = new Menu();  // kalla på menyklassen

                menu.RunMenu(contactListObject); //anropa startmetoden som ska använda sig av listan med kontakter
            }

            Console.ReadKey();  // för att hålla uppe konsollrutan, ................ta bort?
        }
    }
}

