using Avalonia.Controls;
using PTR.GroundStation.ViewModels;

namespace PTR.GroundStation.Views;

public partial class RealtimeDataContent : UserControl
{
    public RealtimeDataContent()
    {
        InitializeComponent();
        DataContext = new RealtimeDataViewModel();
    }
}
