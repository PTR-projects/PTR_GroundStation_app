using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PTR.GroundStation.ViewModels;

public class RocketsPaneViewModel : ReactiveObject
{
    public ObservableCollection<Rocket> Rockets { get; }

    public RocketsPaneViewModel()
    {
        var people = new List<Rocket>
            {
                new Rocket(0, "Solaris"),
                new Rocket(1, "Meteorek")
            };
        Rockets = new ObservableCollection<Rocket>(people);
    }
}

public class Rocket
{
    public uint Identifier { get; set; }
    public string Name { get; set; }
    public bool ShowOnMap { get; set; }
    public bool ShowOnPlot { get; set; }
    public bool ShowOnRealtime { get; set; }

    public Rocket(uint identifier, string name) : base()
    {
        Identifier = identifier;
        Name = name;
    }
}
