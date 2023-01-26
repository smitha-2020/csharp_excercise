using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    private static void Main(string[] args)
    {
        //Challenge 1
        /* create variables from these countries
        Finland: 
        - Name: Finland
        - Population: 5530719
        - Region: Europe,
        - Capital: Helsinki
        - GDP: 27.3
        - Languages: Finnish, Swedish
        - Cities: Helsinki, Tampere, Lahti, Porvo, Kemi
        - Borders: Norway, Sweden, Russia
         */
        //var CountriesArr = new Countries();
        var Finland = new Country("Finland", "Helsinki", 5530719, 43.0f);
        Finland.Region = EnumRegion.NorthernEurope;
        List<Languages> languagesList = new List<Languages>();
        languagesList.Add(new Languages("Finnish", true));
        languagesList.Add(new Languages("Swedish", false));
        languagesList.Add(new Languages("English", false));
        Finland.languages = languagesList.ToArray<Languages>();
        // converts List to Array:
        //Languages[] Finland.Languages = languagesList.ToArray<Languages>();
        for (var i = 0; i < Finland.languages.Count(); i++)
        {
            if (Finland.languages[i].IsDefault)
            {
                Console.WriteLine(Finland.languages[i].Language);
            }
        }
        Finland.borders = EnumBorderCountry.Norway | EnumBorderCountry.Sweden | EnumBorderCountry.Russia;

        var Denmark = new Country("Denmark", "Luxemburg", 5030719, 92.3f);
        Denmark.Region = EnumRegion.SouthernEurope;
        Denmark.borders = EnumBorderCountry.Sweden | EnumBorderCountry.Norway;

        var Sweden = new Country("Sweden", "Stockholm", 5530719, 42.3f);
        Sweden.Region = EnumRegion.SouthernEurope;
        Sweden.borders = EnumBorderCountry.Russia | EnumBorderCountry.Finland;

        var Norway = new Country("Norway", "Oslo", 5530719, 73.3f);
        Norway.Region = EnumRegion.SouthernEurope;
        Norway.borders = EnumBorderCountry.Sweden | EnumBorderCountry.Denmark;

        Console.WriteLine(Country.HasBorder(Finland.borders, Sweden.borders));

        Finland.Cities[0] = new City("Helsinki", true, 658864);
        Finland.Cities[1] = new City("Tampere", false, 244315);
        Finland.Cities[2] = new City("Lahti", false, 120093);
        Finland.Cities[3] = new City("Joensuu", false, 120093);

        var FinCities = Finland.Cities[0..3];

        foreach (var city in FinCities)
        {
            Console.WriteLine(city.CityName);
        }
        Country.CountriesList[0] = Finland;
        Country.CountriesList[1] = Sweden;
        Country.CountriesList[2] = Norway;
        Country.HasBorder(Finland);
        Console.WriteLine(Country.CheckWealth(Denmark));
    }
    class Room
    {
        /* provide your code for challenge 2 here */
    }

    class Player
    {
        /* provide your code for challenge 2 here */
    }
}

