using System.Text.Json;

public class Actor
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Country { get; set; }
    public bool IsAlive { get; set; }

    public void LoadJsonActor(string path)
    {
        string element = File.ReadAllLines(path).First();
        Actor character = JsonSerializer.Deserialize<Actor>(element);
        this.FirstName = character.FirstName;
        this.LastName = character.LastName;
        this.BirthDate = character.BirthDate;
        this.Country = character.Country;
        this.IsAlive = character.IsAlive;
    }

}
