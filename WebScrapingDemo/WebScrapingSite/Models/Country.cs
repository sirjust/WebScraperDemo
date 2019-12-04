using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebScrapingSite.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public Country(int id, string name)
        {
            ID = id;
            CountryName = name;
        }
    }
}