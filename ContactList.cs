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
            People testPerson1 = new People("John", "Snow", "BastardBoi", "snow_01@gmail.com", "John S Harington", "John Snow Targaryen", "MrSnowyBastard01", "MrSnowyAtTheNightWatchTweets", "CoderOfTheWall", "Pannkakor", "Selleri", "En söt liten vargunge", "Romans", false, false);
            contactList.Add(testPerson1);

            People testPerson2 = new People("Henry", "Cavill", "ButcherOfBlaviken", "superman_ur_hero@live.se", "HenryCavill", "Henry Kent of Rivia", "PicsOfDoggiesAndMeLiftingStuff", "WitcherWithWitt", "SuperCoderManOfRivia", "Vad som helst med PROTEIN till mina muskler", "Leverpastej", "Hund", "Action", false, true);
            contactList.Add(testPerson2);

            People testPerson3 = new People("Jason", "Momoa", "MySunAndStars", "khal_momoa@fishmail.com", "Arthur J Momoa", "Jason Momoa f.d. Curry", "FishManPhotos", "DrogoFunnyTweets", "ProgoDrogo", "Pizza", "Fisk", "Hästar och fiskar", "Skräckis", true, false);
            contactList.Add(testPerson3);

        }

        
        //-----------------------------CRUDL metoder som anropas i menu-------------------------------------

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

            Console.WriteLine("Ange om du vill blocka denna kontakt. Svara med 'ja' eller 'nej':");            // TODO: nej eller felsvar...
            string inputIsBlockedString = Console.ReadLine();
            newPerson.IsBlocked = false;
            if(inputIsBlockedString == "ja")
            {
                newPerson.IsBlocked = true;
            }

            Console.WriteLine("Ange om du vill ghosta denna kontakt. Svara med 'ja' eller 'nej':");      // TODO: nej eller felsvar...
            string inputIsGhostedString = Console.ReadLine();
            newPerson.IsGhosted = false;
            if (inputIsGhostedString == "ja")
            {
                newPerson.IsGhosted = true;
            }

            contactList.Add(newPerson);  // lägg till den nya personen i kontaktlistan                                                 FUNKAR EJ

            // återvänder automatiskt till menyn
        }
        //-----------------------------------------------------------------------------------------------------------
        public void Read()  //öppna kontakt.... lista???
        {
            //lista på alla alias...
            foreach (var person in contactList)   //????????????
            {
               // contactList.Sort(alias);  //???
                Console.WriteLine(person);
            }

            Console.WriteLine("Ange alias på den du vill visa:");
            string userInputAlias = Console.ReadLine();



            foreach (var person in contactList)   //????????????
            {
                // contactList.Sort(alias);  //???
                if (userInputAlias == person.Alias)
                {
                    Console.WriteLine("Namn: " + person.Name);
                    Console.WriteLine("Efternamn: " + person.LastName);
                    Console.WriteLine("Alias: " + person.Alias);
                    Console.WriteLine("Email: " + person.Email);
                    Console.WriteLine("LinkedIn: " + person.LinkedIn);
                    Console.WriteLine("Facebook: " + person.Facebook);
                    Console.WriteLine("Instagram: " + person.Instagram);
                    Console.WriteLine("Twitter: " + person.Twitter);
                    Console.WriteLine("Github: " + person.Github);
                    Console.WriteLine("Favoritmat: " + person.FavFood);
                    Console.WriteLine("Avsky-mat: " + person.LeastFavFood);
                    Console.WriteLine("Favoritdjur: " + person.FavAnimal);
                    Console.WriteLine("Favorit-filmgenre: " + person.FavMovieGenre);
                    Console.WriteLine("Blockad: " + person.IsBlocked);
                    Console.WriteLine("Ghostad: " + person.IsGhosted);

                  }
            }

            // återvänd till menyn
        }
        //-----------------------------------------------------------------------------------------------------------
        public void Update() // uppdatera infon i en av dina kontakter
        {
            //välj vilken kontakt, välj vad som ska uppdateras, skriv in och uppdatera...
            //lista på alla alias...
            foreach (var person in contactList)   //????????????
            {
                // contactList.Sort(alias);  //???
                Console.WriteLine(person);
            }

            Console.WriteLine("Ange alias på den du vill uppdatera:");
            string userInputAlias = Console.ReadLine();                            // userInputAlias... behöver man byta namn när den återanvänds i en annan metod?



            // återvänd till menyn
        }
        //-----------------------------------------------------------------------------------------------------------
        public void Delete() // ta bort en av dina kontakter
        {
            //välj vilken kontakt som ska tas bort, ta bort...
            foreach (var person in contactList)   //????????????
            {
                // contactList.Sort(alias);  //???
                Console.WriteLine(person);
            }

            Console.WriteLine("Ange alias på den du önskar ta bort från din kontaktlista... Var personen inte bra nog? Du förtjänar en drömprins!!! Du kan även välja att ta bort 'alla' kontakter...");
            string userInputAlias = Console.ReadLine();

            contactList.Remove(userInputAlias);   // alt. RemoveAt(index) rätt men ska ta int

            //ta bort alla kontakter
            if (userInputDelete == "alla")
            {
                contactList.Clear();
            }

            // återvänd till menyn
        }
        //-----------------------------------------------------------------------------------------------------------
        public void List() // lista alla kontakter, lista kontakter som börjar på en specifik bokstav
        {
            // foreach och cw listan

            Console.WriteLine("Din kontaktlista består av " + contactList.Count() + " kontakter. Någon av de alla borde väl kunna duga...?"); // visa hur många som finns i kontaktlistan

            //fråga om bokstav, kolla att det är en bokstav, foreach alla med den bokstaven och cw...????

            // återvänd till menyn
        }
        //-----------------------------------------------------------------------------------------------------------
    }
}
