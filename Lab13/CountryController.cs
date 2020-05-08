using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class CountryController
    {
        public List<Country> CountryDB = new List<Country>();

        public CountryController()
        {
            Country g = new Country();
            List<string> gColors = new List<string>() { "Gold, Red, Black" };
            g.Name = "Germany";
            g.Continent = "Europe";
            g.Colors = gColors;
            CountryDB.Add(g);

            Country b = new Country();
            List<string> bColors = new List<string>() { "Green, Blue, Yellow" };
            b.Name = "Brazil";
            b.Continent = "South America";
            b.Colors = bColors;
            CountryDB.Add(b);

            Country j = new Country();
            List<string> jColors = new List<string>() { "White, Red" };
            j.Name = "Japan";
            j.Continent = "Asia";
            j.Colors = jColors;
            CountryDB.Add(j);

            Country s = new Country();
            List<string> sColors = new List<string>() { "Green, Yellow, Red" };
            s.Name = "Senegal";
            s.Continent = "Africa";
            s.Colors = sColors;
            CountryDB.Add(s);

            Country z = new Country();
            List<string> zColors = new List<string>() { "Black, White, Red" };
            z.Name = "New Zealand";
            z.Continent = "Oceania";
            z.Colors = zColors;
            CountryDB.Add(z);
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");

            clv.Display();
            int index = int.Parse(Console.ReadLine().Trim());
            if (index < CountryDB.Count && index >= 0)
            {
                Country c = CountryDB[index];
                CountryAction(c);
                Run();
            }
            else
            {
                Console.WriteLine($"\nPlease enter a number between 0 and {CountryDB.Count - 1}\n");
                WelcomeAction();
            }
        }
        public void Run()
        {
            Console.WriteLine("\nWould you like to learn about another country? y/n");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                Console.WriteLine();
                WelcomeAction();
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("\nPlease enter y or n");
                Run();
            }
        }
    }
}
