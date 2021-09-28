using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class People
    {
        public string name; // public eftersom de ska kunnas ändras utanför klassen, i main...
        public string lastName;
        public string alias;
        public string email;
        public string linkedIn;
        public string facebook;
        public string instagram;
        public string twitter;
        public string github;
        public string favFood;
        public string leastFavFood;
        public string favAnimal;
        public string favMovieGenre;
        public bool isBlocked = false;   //private?
        public bool isGhosted = false;    //private?
        //  public int age;   inte ett måste, lägg till senare...  födelsedagar osv..... timedate??

        public string getData()
        {
            return "Namn: " + this.name + " Efternamn: " + this.lastName + " Alias: " + this.alias + " Email: " + this.email + " LinkedIn: " + this.linkedIn
            + " Facebook: " + this.facebook + " Instagram: " + this.instagram + " Twitter: " + this.twitter + " Github: " + this.github
             + " Favoritmat: " + this.favFood + " Avskymat: " + this.leastFavFood + " Favoritdjur: " + this.favAnimal + " Favorit-filmgenre: " + this.favMovieGenre
             + " Blockad av dig?: " + this.isBlocked + " Ghostad av dig? : " + isGhosted;

        }


        //public static int Count; // static täcker hela klassen, inte specifikt ett objekt. använd stor bokstav på namnet av en static variabel. denna räknar hur många personer som finns i chatup...

        //public People(string _name, string _lastName, string _alias, string _email, string _linkedIn, string _facebook, string _instagram, string _twitter, string _github, string _favFood, string _leastFavFood, string _favAnimal, string _favMovieGenre, bool _isBlocked, bool _isGhosted); // constructor...
        //    {   
        //       name = _name;
        //       lastName= _lastname;
        //       alias = _alias;
        //       email = _email;
        //       linkedIn = _linkedIn;
        //       facebook = _facebook; 
        //       instagram = _instagram;
        //       twitter = _twitter;
        //       github = _github; 
        //       favFood= _favFood;
        //       leastFavFood = _leastFavFood;
        //       favAnimal = _favAnimal; 
        //       favMovieGenre = _favMovieGenre;
        //       isBlocked = _isBlocked;
        //       isGhosted = _isGhosted;

       

   

}
    }

