namespace IDOS.ViewModels;

public class StopGroup
{
    public string Name { get; set; }
    public List<Stop> Stops { get; set; }

   // public int Page { get; set; } = 1;

   // public List<Stop> humus { get; set; } = new List<Stop>();

/*    public List<Stop> StopsLimit
    {
        get
        {
            for (int i = Page; i < Page * 10;)
            {
                humus.Add(Stops.ElementAt(i));
            }

            return humus;
        }
        set { ; }
    }*/
}