using System;
using System.Collections.Generic;  // list<>
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class ContactList  //class
    {

        List<People> contactList;  //lista... skapas här???????

        public ContactList() // constructor
        {
            contactList = new List<People>(); // gör en tom kontaktlista 
        }


        //CRUDL metoder som anropas i menu

        public void Create()  // lägg till ny kontakt
        {
            People newPerson = new People();
            
            Console.WriteLine("Du har valt att skapa en ny kontakt!");

            Console.WriteLine("Ange namn:");
            newPerson.Name = Console.ReadLine();

            Console.WriteLine("Ange efternamn:");
            newPerson.LastName = Console.ReadLine();

            Console.WriteLine("Ange Alias:");
            newPerson.Alias = Console.ReadLine();

            Console.WriteLine("Ange Email:");
            newPerson.Email = Console.ReadLine();

            Console.WriteLine("Ange LinkedIn:");
            newPerson.LinkedIn = Console.ReadLine();

            Console.WriteLine("Ange Facebook:");
            newPerson.Facebook = Console.ReadLine();

            Console.WriteLine("Ange Instagram:");
            newPerson.Instagram = Console.ReadLine();

            Console.WriteLine("Ange Twitter:");
            newPerson.Twitter = Console.ReadLine();

            Console.WriteLine("Ange Github:");
            newPerson.Github = Console.ReadLine();

            Console.WriteLine("Ange favorit-maträtt:");
            newPerson.FavFood = Console.ReadLine();

            Console.WriteLine("Ange avsky-maträtt:");
            newPerson.LeastFavFood = Console.ReadLine();

            Console.WriteLine("Ange favoritdjur:");
            newPerson.FavAnimal = Console.ReadLine();

            Console.WriteLine("Ange favorit-filmgenre:");
            newPerson.FavMovieGenre = Console.ReadLine();

            Console.WriteLine("Ange om du vill blocka denna kontakt. Svara med ja eller nej:");
            // newPerson.IsBlocked = Console.ReadLine();                                                         ?????

            Console.WriteLine("Ange om du vill ghosta denna kontakt. Svara med ja eller nej:");
            // newPerson.IsGhosted = Console.ReadLine();                                                           ??????

            contactList.Add(newPerson);

            // återvänder automatiskt till menyn
        }

        public string Read()  //öppna kontakt.... lista???
        {
            string returnString = "";
            return returnString;

            // återvänd till menyn
        }

        public void Update() // uppdatera infon i en av dina kontakter
        {
            //välj vilken kontakt, välj vad som ska uppdateras, skriv in och uppdatera...
            // återvänd till menyn
        }

        public void Delete() // ta bort en av dina kontakter
        {
            //välj vilken kontakt som ska tas bort, ta bort...
            // återvänd till menyn
        }

        public void List() // lista alla kontakter, lista kontakter som börjar på en specifik bokstav
        {
            // foreach och cw listan

            //fråga om bokstav, kolla att det är en bokstav, foreach alla med den bokstaven och cw...????

            // återvänd till menyn
        }

    }
}
