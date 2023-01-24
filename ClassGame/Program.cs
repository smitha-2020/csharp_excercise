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
        var CountriesArr = new Countries();
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
            Console.WriteLine(Finland.languages[i].IsDefault ? Finland.languages[i].Language : "");
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

        //Debug.Assert(Country.HasBorder(Finland) == true);
        // List<Cities> cityList = new List<Cities>();
        // cityList.Add(new Cities("Helsinki", true, 658864));
        // cityList.Add(new Cities("Tampere", false, 244315));
        // cityList.Add(new Cities("Lahti", false, 120093));
        // cityList.Add(new Cities("Joensuu", false, 120093));
        // Finland.CitiesArr = cityList.ToArray<Cities>();
        // for (var i = 0; i < Finland.CitiesArr.Count(); i++)
        // {
        //     Console.WriteLine(Finland.CitiesArr[i].IsCapital ? Finland.CitiesArr[i].CityName : "");   //Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        // }

        // CountriesArr.CountriesList[0] = Finland;
        // CountriesArr.CountriesList[1] = Sweden;
        // CountriesArr.CountriesList[2] = Norway;

        // List<Country> countriesList = new List<Country>();
        // countriesList.Add(Finland);
        // countriesList.Add(Sweden);

        // Country.Countries = countriesList.ToArray<Country>();
        // for (var i = 0; i < CountriesArr.CountriesList.Count(); i++)
        // {
        //     Console.WriteLine($"{CountriesArr.CountriesList[i].CountryName}: {CountriesArr.CountriesList[i].Capital}");   //Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        // }

        // Country.Countries[0] = Finland;
        // Country.Countries[0] = Sweden;
        //    for (var i = 0; i < Country.Countries.Count(); i++)
        // {
        //     Console.WriteLine($"{Country.Countries[i].CountryName}: {Country.Countries[i].Capital}");   //Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        // }

        //Finland.languages.add();
        // Finland.setCountryLanguages();
        // Finland.setCountryLanguages(Finland.CountryName, "Swedish", false);
        // Finland.getLanguages();
        //Finland.getLanguages();
        //Country.HasBorder("Finland");
        //Console.WriteLine(Country.CheckWealth(Finland));
        // var FinCities = Finland[0..4];
        // var FirstCity = Finland[0];
        /* Write methods to print FinCities and FirstCity */

        //Challenge 2
        /* write your own game */
    }
    class Countries
    {
        public Country[] CountriesList = new Country[100];
        public Country this[Index Index]
        {
            get
            {
                return CountriesList[Index];
            }
            set
            {
                CountriesList[Index] = value;
            }
        }
        public Country[] this[Range range]
        {
            get
            {
                return CountriesList[range];
            }

        }

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

