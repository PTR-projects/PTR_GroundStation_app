namespace PTR.GroundStation.ViewModels;

public class Rocket
{
    public Rocket(uint identifier, string name) : base()
    {
        Identifier = identifier;
        Name = name;
    }

    public uint Identifier { get; set; }
    public string Name { get; set; }
    public bool ShowOnMap { get; set; }
    public bool ShowOnPlot { get; set; }
    public bool ShowOnRealtime { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public float Altitude { get; set; }

}
