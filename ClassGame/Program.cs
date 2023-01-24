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
        var Finland = new Country("Finland", "Helsinki", 5530719, 27.3);
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


        var Sweden = new Country("Sweden", "Stockholm", 5530719, 27.3);
        Sweden.Region = EnumRegion.SouthernEurope;
        Sweden.borders = EnumBorderCountry.Norway | EnumBorderCountry.Finland;

        Console.WriteLine(Country.HasBorder(Finland.borders, Sweden.borders));
        //Debug.Assert(Country.HasBorder(Finland) == true);
        List<Cities> cityList = new List<Cities>();
        cityList.Add(new Cities("Helsinki", true, 658864));
        cityList.Add(new Cities("Tampere", false, 244315));
        cityList.Add(new Cities("Lahti", false, 120093));
        cityList.Add(new Cities("Joensuu", false, 120093));
        Finland.cities = cityList.ToArray<Cities>();
        for (var i = 0; i < Finland.cities.Count(); i++)
        {
            Console.WriteLine(Finland.cities[i].IsCapital ? Finland.cities[i].CityName : "");   //Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        }
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
    public enum EnumRegion
    {
        NorthernEurope,
        SouthernEurope,
        EasternEurope,
        WesternEurope
    }
    public enum EnumBorderCountry
    {
        None = 0b_0000_0000,
        Norway = 0b_0000_0001,
        Sweden = 0b_0000_0010,
        Russia = 0b_0000_0100,
        Finland = 0b_0000_1000
    }

    class Country
    {
        /* provide your code for challenge 1 here */
        public readonly string CountryName;
        public long Population;
        public EnumRegion Region;
        public string Capital { get; init; }
        public double Gdp;
        public Languages[]? languages;
        public Cities[]? cities;
        public EnumBorderCountry borders;
        // private string? _langugage;
        // private bool _isDefault;
        // private string? _cntry;

        //constructor
        public Country(string country, string capital, long population, double gdp)
        {
            if (country == null)
            {
                throw new ArgumentException("Country name is a readonly property should be set and cannot be null");
            }
            CountryName = country;
            Capital = capital;
            Population = population;
            Gdp = gdp;
        }
        public static bool HasBorder(Country name) => name.borders > 0 ? true : false;

        public static EnumBorderCountry HasBorder(EnumBorderCountry borderCountry1, EnumBorderCountry borderCountry2) => (borderCountry1 & borderCountry2);

        // public static bool HasBorder(Country name) => name.borders.Length > 0 ? true : false;

        public static bool CheckWealth(Country name)
        {
            return true;
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

