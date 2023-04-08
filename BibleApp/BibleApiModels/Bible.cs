namespace BibleApp.BibleApiModels;

// TODO check and fix any incorrect property datatypes

public class Bible
{
    public string id { get; set; }
    public string dblId { get; set; }
    public object relatedDbl { get; set; }
    public string name { get; set; }
    public string nameLocal { get; set; }
    public string abbreviation { get; set; }
    public string abbreviationLocal { get; set; }
    public string description { get; set; }
    public string descriptionLocal { get; set; }
    public Language language { get; set; }
    public Country[] countries { get; set; }
    public string type { get; set; }
    public DateTime updatedAt { get; set; }
    public string copyright { get; set; }
    public string info { get; set; }
    //public object[] audioBibles { get; set; }
}

public class Language
{
    public string id { get; set; }
    public string name { get; set; }
    public string nameLocal { get; set; }
    public string script { get; set; }
    public string scriptDirection { get; set; }
}

public class Country
{
    public string id { get; set; }
    public string name { get; set; }
    public string nameLocal { get; set; }
}