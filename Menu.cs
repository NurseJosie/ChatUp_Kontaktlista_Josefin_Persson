using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Menu  //class
    {

        public Menu()   //constructor, behövs i ALLA klasser. ok att den är tom...
        {
            // innhehåller inget
        }

        public void RunMenu(ContactList contactList) // menymetod som tar info från en ContactList kallad contactList...
        {
            Console.Clear();
            Console.WriteLine("|----------|");
            Console.WriteLine("|---MENY---|");
            Console.WriteLine("|----------|");
            Console.WriteLine("Ange tillhörande siffra för att välja ett alternativ");
            Console.WriteLine("1- Skapa ny kontakt");
            Console.WriteLine("2- Visa kontakt");
            Console.WriteLine("3- Uppdatera kontakt");
            Console.WriteLine("4- Ta bort kontakt");
            Console.WriteLine("5- Lista alla kontakter");
            Console.WriteLine("6- Lista alla som börjar på spec. bokstav");
            

            string userInput = Console.ReadLine();  // ta input och parsa den
            int userInputInt = 0;
            int.TryParse(userInput, out userInputInt);

            if (userInputInt > 6 || userInputInt < 0)  
            {
                Console.WriteLine("Välj ett alternativ mellan 1-6 från menyn!");

                Console.ReadKey();
            }

            switch (userInputInt)
            {
                case 1:
                    // skapa kontakt
                    // anropa metoder från contactlist...
                    contactList.Create();
                    break;
                case 2:
                    //öppna kontakter
                    contactList.Read();
                    break;
                case 3:
                    // redigera kontakter
                    contactList.Update();
                    break;
                case 4:
                    // ta bort kontakt
                    contactList.Delete();
                    break;
                case 5:
                    // lista alla kontakter
                    contactList.List();
                    break;
                case 6:
                    //lista alla kontakter som börjar på en spec. bokstav
                    contactList.ListByLetter();
                    break;

                default:
                    break;
            }
        }
    }
}
