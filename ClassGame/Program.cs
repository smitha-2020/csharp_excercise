using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

class Program
{
    private static void Main(string[] args)
    {
        StringBuilder builder = new StringBuilder();
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
        for (var i = 0; i < Finland.languages.Count(); i++)
        {
            if (Finland.languages[i].IsDefault)
            {
                Console.WriteLine($"Default Language Spoken in Finland is {Finland.languages[i].Language}");
            }
        }
        Console.WriteLine("*******************************************************************************");
        Finland.borders = EnumBorderCountry.Norway | EnumBorderCountry.Sweden | EnumBorderCountry.Russia;

        var Luxemburg = new Country("Luxemburg", "Luxemburg", 5030719, 92.3f);
        Luxemburg.Region = EnumRegion.SouthernEurope;
        Luxemburg.borders = EnumBorderCountry.Sweden | EnumBorderCountry.Norway;

        var Sweden = new Country("Sweden", "Stockholm", 5530719, 42.3f);
        Sweden.Region = EnumRegion.SouthernEurope;
        Sweden.borders = EnumBorderCountry.Russia | EnumBorderCountry.Finland;

        var Norway = new Country("Norway", "Oslo", 5530719, 73.3f);
        Norway.Region = EnumRegion.SouthernEurope;
        Norway.borders = EnumBorderCountry.Sweden | EnumBorderCountry.Denmark;

        Console.WriteLine($"Finland and Sweden share thier borders with {Country.HasBorder(Finland.borders, Sweden.borders)}");
        Console.WriteLine("*******************************************************************************");


        Finland.Cities[0] = new City("Helsinki", true, 658864);
        Finland.Cities[1] = new City("Tampere", false, 244315);
        Finland.Cities[2] = new City("Lahti", false, 120093);
        Finland.Cities[3] = new City("Joensuu", false, 120093);

        var FinCities = Finland.Cities[0..3];
        builder.Append("Finland has");
        foreach (var city in FinCities)
        {
            builder.Append($" {city.CityName},");
            //Console.WriteLine(city.CityName);
        }
        builder.Append(" Cities");
        Console.WriteLine(builder.ToString());
        Console.WriteLine("*******************************************************************************");
        Country.CountriesList[0] = Finland;
        Country.CountriesList[1] = Sweden;
        Country.CountriesList[2] = Norway;
        EnumBorderCountry FI = EnumBorderCountry.Finland;
        Country.HasBorder(FI);
        Console.WriteLine("*******************************************************************************");
        Console.WriteLine($"Luxemburg is voted as {Country.CheckWealth(Luxemburg)}");

        //Console.WriteLine((int)EnumBorderCountry.Finland);
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

