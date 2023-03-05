using IDOS.Repositories;
using IDOS.ViewModels;

namespace IDOS.Services;

public class LineServis
{
    public Repository r = new Repository();
    public List<Line> Search(string Name)
    {
        Repository r = new Repository();
        List<Line> lines = new List<Line>();
        if (!String.IsNullOrEmpty(Name))
        {
            foreach (StopGroup stopGroup in r.LoadStops().StopGroups)
            {
                foreach (Stop stop in stopGroup.Stops)
                {
                    foreach (Line line in stop.Lines)
                    {
                        if (line.Name.Contains(Name))
                        {
                            lines.Add(line);
                        }
                    }
                }
            }
            return lines.DistinctBy(i => i.Name).ToList();
        }
        List<Line> allSLines = new List<Line>();
        foreach (StopGroup stopGroup in r.LoadStops().StopGroups)
        {
            foreach (Stop stop in stopGroup.Stops)
            {
                foreach (Line line in stop.Lines)
                {
                    allSLines.Add(line);
                }
            }
        }
        return allSLines.DistinctBy(i => i.Name).ToList();
    }
}