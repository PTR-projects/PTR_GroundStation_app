using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PTR.GroundStation
{
    public partial class SettingsPane : UserControl
    {
        public SettingsPane()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}