using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class CountryView
    {
        public Country DisplayCountry;
        public CountryView(Country c)
        {
            this.DisplayCountry = c;
        }

            public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            //Console.Write("Colors: ");
            foreach (string c in DisplayCountry.Colors)
            {
                Console.WriteLine($"Colors: {c}");
            }
        }


    }
}
