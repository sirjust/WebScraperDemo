using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebScrapingSite.Models
{
    public class SampleData
    {
        public List<Country> Countries { get; set; }
        public List <PersonData> People { get; set; }

        public SampleData()
        {
            Countries = new List<Country>();
            People = new List<PersonData>();

            Countries.Add(new Country(1, "United Kingdom"));
            Countries.Add(new Country(2, "United States"));
            Countries.Add(new Country(3, "Republic of Ireland"));
            Countries.Add(new Country(4, "India"));

            People.Add(new PersonData(1, 1, "Justin"));
            People.Add(new PersonData(2, 2, "Bill"));
            People.Add(new PersonData(3, 3, "Fred"));
            People.Add(new PersonData(4, 4, "Mary"));
        }
    }
}