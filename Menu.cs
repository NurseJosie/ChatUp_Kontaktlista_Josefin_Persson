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
            Console.WriteLine("7- Avsluta programmet");

            userInput = Console.ReadLine();  // ta input och parsa den
            int.TryParse(userInput, out userInputInt);

            if (!isUserInputInt)  //om det är sant att input INTE är en int????????????????????????????????????????????
            {
                Console.WriteLine("Välj ett alternativ mellan 1-7 från menyn!");
            }

            switch (userInputInt)
            {
                case 1:
                    // skapa kontakt
                    // anropa metoder från contactlist...
                    Create();
                    break;
                case 2:
                    //öppna kontakter
                    Read();
                    break;
                case 3:
                    // redigera kontakter
                    Update();
                    break;
                case 4:
                    // ta bort kontakt
                    Delete();
                    break;
                case 5:
                    // lista alla kontakter
                    List();
                    break;
                case 6:
                    //lista alla kontakter som börjar på en spec. bokstav
                    break;

                default:
                    break;
            }
    }
}
