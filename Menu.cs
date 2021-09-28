using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Menu
    {

        public Menu()
        {

        }

        public void RunMenu(ContactList contactList) //menymetod?? while???
        {
            Console.WriteLine("meny");
            Console.WriteLine("1- skapa");
            Console.WriteLine("2- läsa andra profiler");
            Console.WriteLine("3-uppdatera min profil");
            Console.WriteLine("4- ta bort profil");
            Console.WriteLine("5- lista alla");
            Console.WriteLine("6- lista alla som börjar på spec. bokstav");
            string userInput;
            int userInputInt;
            bool isUserInputInt = false;

            userInput = Console.ReadLine();
            int.TryParse(userInput, out userInputInt);

            if (!isUserInputInt)
            {
                Console.WriteLine("Välj ett alternativ mellan 1-6 från menyn!");
                // continue;   ??
            }


            //switch
            switch (userInputInt)
            {
                case 1:
                    // skapa profil
                    break;
                case 2:
                    //läsa andra profiler
                    break;
                case 3:
                    // ändra i min egen profil
                    break;
                case 4:
                    // ta bort min profil
                    break;
                case 5:
                    // lista alla profiler
                    break;
                case 6:
                    //lista alla profiler som börjar på en spec. bokstav
                    break;

                default:
                    break;
            }
        }
    }
}
