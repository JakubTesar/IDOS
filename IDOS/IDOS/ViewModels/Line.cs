using IDOS.Repositories;

namespace IDOS.ViewModels;

public class Line
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }

    public List<Stop> Stops { get; set; } = new List<Stop>();

    public List<Stop> getStopsByLine(int ID)
    {
        Repository r = new Repository();
        foreach (StopGroup stopGroup in r.LoadStops().StopGroups)
        {
            foreach (Stop stop in stopGroup.Stops)
            {
                foreach (Line line in stop.Lines)
                {
                    if (line.ID == ID)
                    {
                     Stops.Add(stop);   
                    }
                }
            }
        }

        return Stops.DistinctBy(i => i.altIdosName).ToList();
    }
}