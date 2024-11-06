using System.Text.Json;

public class Episode
{
    public string Title { get; set; }
    public int DurationMinutes { get; set; }
    public int SequenceNumber { get; set; }
    public string Director { get; set; }
    public string Synopsis { get; set; }
    public List<Character> Characters { get; set; } = new List<Character>();


    public void LoadJsonEpisode(string path)
    {
        string element = File.ReadAllLines(path).First();
        Episode episode = JsonSerializer.Deserialize<Episode>(element);
        this.Title = episode.Title;
        this.DurationMinutes = episode.DurationMinutes;
        this.SequenceNumber = episode.SequenceNumber;
        this.Director = episode.Director;
        this.Synopsis = episode.Synopsis;
    }

}
