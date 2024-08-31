using Avalonia.Controls;

namespace PTR.GroundStation.Views;

public partial class MapContent : UserControl
{
    public MapContent()
    {
        InitializeComponent();
        var mapControl = new Mapsui.UI.Avalonia.MapControl();
        mapControl.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
        Content = mapControl;
    }
}
