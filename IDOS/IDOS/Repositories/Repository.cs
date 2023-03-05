using System.Text.Json;
using IDOS.ViewModels;

namespace IDOS.Repositories;

public class Repository
{
    public StopClass ReplaceLomeno()
    {
        string jsonString = File.ReadAllText("stops.json");
        StopClass stopClass = JsonSerializer.Deserialize<StopClass>(jsonString, new JsonSerializerOptions
            { PropertyNameCaseInsensitive = true });
        foreach (StopGroup varStopGroup in stopClass.StopGroups)
        {
            foreach (Stop varStop in varStopGroup.Stops)
            {
                varStop.ID = varStop.ID.Replace("/", "69");
            }
        }

        return stopClass;
    }

    public StopClass? LoadStops()
    {
        return ReplaceLomeno();
    }

    public void GetAll()
    {
        List<StopGroup> stopGroup = LoadStops().StopGroups;
    }
}