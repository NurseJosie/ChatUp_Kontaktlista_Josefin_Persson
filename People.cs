using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    public class People //class som skapar enskilda kontakt-objekt      
    {
        public string Name;     // get set
        public string LastName;
        public string Alias;
        public string Email;
        public string LinkedIn;
        public string Facebook;
        public string Instagram;
        public string Twitter;
        public string Github;
        public string FavFood;
        public string LeastFavFood;
        public string FavAnimal;
        public string FavMovieGenre;
        public bool IsBlocked;
        public bool IsGhosted;

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


        
}
}

