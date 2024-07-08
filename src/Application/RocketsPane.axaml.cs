using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PTR.GroundStation
{
    public partial class RocketsPane: UserControl
    {
        public RocketsPane()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}