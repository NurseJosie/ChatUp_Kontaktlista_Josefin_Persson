using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class ContactList
    {

        List<People> contactList;

        public ContactList()
        {
            contactList = new List<People>(); //kontaktlista med alla personer
            contactList.Add(new People());   // ContactList eller contactlist???!
            contactList[0].name = "John";
            contactList[0].lastName = "Snow";
            contactList[0].alias = "Bastard";
            contactList[0].email = "snowy_bastard01@westeros.com";
            contactList[0].linkedIn = "a";
            contactList[0].facebook = "a";
            contactList[0].instagram = "a";
            contactList[0].twitter = "a";
            contactList[0].github = "a";
            contactList[0].favFood = "a";
            contactList[0].leastFavFood = "a";
            contactList[0].favAnimal = "a";
            contactList[0].favMovieGenre= "a";

        }


        //CRUDL methods below


    }
}
