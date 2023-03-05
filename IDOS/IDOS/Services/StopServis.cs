using IDOS.Repositories;
using IDOS.ViewModels;

namespace IDOS.Services;

public class StopServis
{
    public Repository r = new Repository();
    public Stop Filter(string ID)
    {
        foreach (StopGroup s in r.LoadStops().StopGroups)
        {
            foreach (Stop ss in s.Stops)
            {
                if (ss.ID == ID)
                {
                    return ss;
                }
            }
        }

        return new Stop();
    }

    public List<Stop> Search(string Name)
    {
        Repository r = new Repository();
        List<Stop> stops = new List<Stop>();
        if (!String.IsNullOrEmpty(Name))
        {
            foreach (StopGroup stopGroup in r.LoadStops().StopGroups)
            {
                foreach (Stop stop in stopGroup.Stops)
                {
                    if (stop.altIdosName.Contains(Name))
                    {
                        stops.Add(stop);
                    }
                }
            }

          
            return stops.DistinctBy(i => i.altIdosName).ToList();
        }

        List<Stop> allStops = new List<Stop>();
        foreach (StopGroup stopGroup in r.LoadStops().StopGroups)
        {
            foreach (Stop stop in stopGroup.Stops)
            {
                allStops.Add(stop);
            }
        }

        return allStops.DistinctBy(i => i.altIdosName).ToList();
    }
}