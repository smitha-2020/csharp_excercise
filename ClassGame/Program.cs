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
        Country.HasBorder(Finland);
        Finland.languages[0] = new Languages("Finnish",true);
        Finland.languages[1] = new Languages("Swedish",false);
        Finland.languages[2] = new Languages("English",false);


        // foreach(var element in Finland.languages){
        //   Console.WriteLine(element.IsDefault?element.Language:null);

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
    public enum EnumRegion
    {
        NorthernEurope,
        SouthernEurope,
        EasternEurope,
        WesternEurope
    }

    class Country
    {
        /* provide your code for challenge 1 here */
        public readonly string CountryName;
        public long Population;
        public EnumRegion Region;
        public string Capital { get; init; }
        public double Gdp;
        public Languages[] languages =new Languages[100];
        public string[]? cities;
        public string[] borders = { "Norway", "Sweden", "Russia" };

        private string? _langugage;
        private bool _isDefault;
        private string? _cntry;

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
        // public void setCountryLanguages(string countryName, string language, bool isDefault)
        // {
        //     _cntry = countryName;
        //     _langugage = language;
        //     _isDefault = isDefault;
        // }
        // public void getLanguages(){
        //     if(this._isDefault){
        //         Console.WriteLine($"{this.CountryName}");
        //     } 
        // }
        public static bool HasBorder(string countryName)
        {
            return true;
        }
        public static bool HasBorder(Country name) => name.borders.Length > 0 ? true : false;

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

