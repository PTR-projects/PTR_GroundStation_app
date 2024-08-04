using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PTR.GroundStation.ViewModels
{
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
        public uint Identitifer { get; }
        public string Name { get; }

        public Rocket(uint identitifer, string name) : base()
        {
            Identitifer = identitifer;
            Name = name;
        }
    }
}
