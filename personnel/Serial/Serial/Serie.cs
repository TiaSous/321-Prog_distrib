
using System.Text.Json;

public class Serie
{
    public List<Episode> episodes;

    public void LoadJsonAllEpisodes(string path)
    {
        string element = File.ReadAllLines(path).First();
        List<Episode> allEpisode = JsonSerializer.Deserialize<List<Episode>>(element);
        episodes = allEpisode;
    }

}




