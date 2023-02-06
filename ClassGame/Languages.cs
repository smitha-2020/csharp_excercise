public class Languages
{
    public string Language  { get; set; }
    public bool IsDefault  { get; set; }

    public Languages(string language, bool isDefault)
    {
        Language = language;
        IsDefault = isDefault;

    }

}