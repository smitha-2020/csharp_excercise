public class City
{
    public string CityName;
    public bool IsCapital;
    public double Population;

    public City(string name, bool isCapital, double population)
    {
        CityName = name;
        IsCapital = isCapital;
        Population = population;
    }
    public void DisplayCity()
    {
        Console.WriteLine($"{CityName}");
       
    }
}