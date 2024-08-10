using Avalonia.Controls;
using PTR.GroundStation.ViewModels;

namespace PTR.GroundStation.Views;

public partial class PlotsContent : UserControl
{
    public PlotsContent()
    {
        InitializeComponent();
        DataContext = new PlotsViewModel();
    }
}
