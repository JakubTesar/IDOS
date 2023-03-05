namespace IDOS.ViewModels;

public class Stop
{
    public List<Line> Lines { get; set; } = new List<Line>();
    public string ID { get; set; }

    public string altIdosName { get; set; }
}