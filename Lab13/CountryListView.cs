using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class CountryListView
    {
        public List<Country> Countries;
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                Country c = Countries[i];
                Console.WriteLine($"{i}: {c.Name}");
            }
        }
    }
}
