using System;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();   //
            Menu menu = new Menu();    //

            while (true) //
            {
                menu.RunMenu(contactList); //anropa startmetoden som ska använda sig av listan med kontakter
            }
        }
    }
}

