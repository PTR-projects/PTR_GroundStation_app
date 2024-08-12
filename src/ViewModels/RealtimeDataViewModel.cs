using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PTR.GroundStation.ViewModels;

public class RealtimeDataViewModel : ReactiveObject
{
    public ObservableCollection<Rocket> Rockets { get; }

    public RealtimeDataViewModel()
    {
        var rockets = new List<Rocket>
            {
                new Rocket(0, "Solaris"),
                new Rocket(1, "Meteorek")
            };

        rockets[0].Altitude = 500;
        rockets[0].Latitude = 50;
        rockets[0].Longitude = 20;
        Rockets = new ObservableCollection<Rocket>(rockets);
    }
}
