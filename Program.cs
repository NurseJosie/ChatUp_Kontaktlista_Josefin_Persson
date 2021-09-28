using System;
using System.Collections.Generic;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) //???
            {
                ContactList contactList = new ContactList();    //skapa lista med kontakter
                Menu menu = new Menu();  // kalla på menyklassen

                menu.RunMenu(contactList); //anropa startmetoden
            }

            Console.ReadKey();
        }    
    }
    }

