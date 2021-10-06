using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class People //class som skapar enskilda kontakt-objekt
    {
        public string Name { get; set; }     //   VARFÖR GET; SET; ????!    public eftersom de ska kunnas ändras utanför klassen, i main...      PASCAL CASE
        public string LastName { get; set; }
        public string Alias { get; set; } 
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Github { get; set; }
        public string FavFood { get; set; }
        public string LeastFavFood { get; set; }
        public string FavAnimal { get; set; }
        public string FavMovieGenre { get; set; }

        public bool IsBlocked = false;   //private?              // get; set; ????
        public bool IsGhosted = false;    //private?

        //  public int age;   inte ett måste, lägg till senare...  födelsedagar osv..... timedate??

        public People() // en tom constructor... så att man ska kunna skapa komma kontakter.... men kontakter med kanske bara tre olika attrubut? skapa massa constructors?!?!
        {
            //tomt
        }

        // constructor! alla värden sätts till default?
        public People(string name, string lastName, string alias, string email, string linkedIn, string facebook, string instagram, string twitter, string github, string favFood, string leastFavFood, string favAnimal, string favMovieGenre, bool isBlocked, bool isGhosted)
                {   
            this.Name = name;                   // this. används i constructorn för att syfta på objektet???          CAMEL CASE
            this.LastName = lastName;
            this.Alias = alias;
            this.Email = email;
            this.LinkedIn = linkedIn;
            this.Facebook = facebook;
            this.Instagram = instagram;
            this.Twitter = twitter;
            this.Github = github;
            this.FavFood = favFood;
            this.LeastFavFood = leastFavFood;
            this.FavAnimal = favAnimal;
            this.FavMovieGenre = favMovieGenre;
            this.IsBlocked = isBlocked;
            this.IsGhosted = isGhosted;
        }

    public string getData()  // metod för att hämta och prestentera data om kontakten
        {
            return "data om kontakten";
            //return "Namn: " + this.name + " Efternamn: " + this.lastName + " Alias: " + this.alias + " Email: " + this.email + " LinkedIn: " + this.linkedIn
            //+ " Facebook: " + this.facebook + " Instagram: " + this.instagram + " Twitter: " + this.twitter + " Github: " + this.github
            // + " Favoritmat: " + this.favFood + " Avskymat: " + this.leastFavFood + " Favoritdjur: " + this.favAnimal + " Favorit-filmgenre: " + this.favMovieGenre
            // + " Blockad av dig?: " + this.isBlocked + " Ghostad av dig? : " + isGhosted;

        }


        //    public static int Count; // static täcker hela klassen, inte specifikt ett objekt. använd stor bokstav på namnet av en static variabel. denna räknar hur många personer som finns i chatup...

        
}
}

