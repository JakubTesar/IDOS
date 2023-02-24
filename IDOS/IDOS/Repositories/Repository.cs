using System.Text.Json;
using IDOS.ViewModels;

namespace IDOS.Repositories;

public class Repositories
{
    public List<StopGroup> Stops { get; set; } = new List<StopGroup>();
    public StopClass? LoadStops()
    {
        string jsonString = File.ReadAllText("stops.json");
        StopClass stopClass = JsonSerializer.Deserialize<StopClass>(jsonString, new JsonSerializerOptions
        {PropertyNameCaseInsensitive = true});
        return stopClass;
    }

    public void GetAll()
    {
        List<StopGroup> stopGroup = LoadStops().StopGroups;
    }
}