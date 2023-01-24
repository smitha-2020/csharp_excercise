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
    Finland = 0b_0000_1000,
    Denmark = 0b_0001_0000
}
public enum WealthIndex
{
    SuperPoor,
    Poor,
    Medium,
    Rich,
    SuperRich
}

public class Country
{
    /* provide your code for challenge 1 here */
    public readonly string CountryName;
    public long Population { get; set; }
    public EnumRegion Region;
    public string Capital { get; init; }
    public double Gdp { get; set; }
    public Languages[]? languages;
    public City[] Cities = new City[5];
    public EnumBorderCountry borders;

    //public static Country[] Countries = new Country[100];
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


    public City this[Index Index]
    {
        get
        {
            return Cities[Index];
        }
        set
        {
            Cities[Index] = value;

        }
    }
    public City[] this[Range range]
    {
        get
        {
            return Cities[range];
        }
    }

}