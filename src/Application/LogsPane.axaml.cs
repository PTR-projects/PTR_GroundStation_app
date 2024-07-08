using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace PTR.GroundStation
{
    public partial class LogsPane : UserControl
    {
        public LogsPane()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}