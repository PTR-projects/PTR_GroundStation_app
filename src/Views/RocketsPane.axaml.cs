using Avalonia.Controls;
using PTR.GroundStation.ViewModels;

namespace PTR.GroundStation.Views;

public partial class RocketsPane : UserControl
{
    public RocketsPane()
    {
        InitializeComponent();
        DataContext = new RocketsPaneViewModel();
    }
}
