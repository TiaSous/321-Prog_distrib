using System.Text.Json;

public class Character
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public Actor PlayedBy { get; set; }

    public void LoadJsonCharacter(string path)
    {
        string element = File.ReadAllLines(path).First();
        Character character = JsonSerializer.Deserialize<Character>(element);
        this.FirstName = character.FirstName;
        this.LastName = character.LastName;
        this.Description = character.Description;
        this.PlayedBy = character.PlayedBy;
    }
}