using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebScrapingSite.Models
{
    public class PersonData
    {
        public int ID { get; set; }
        public string PersonName { get; set; }
        public int Nationality { get; set; }

        public PersonData(int id, int nationality, string name)
        {
            ID = id;
            PersonName = name;
            Nationality = nationality;
        }
    }
}