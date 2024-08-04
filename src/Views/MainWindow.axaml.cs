using Avalonia.Controls;
using System;
using System.Collections.Generic;

namespace PTR.GroundStation.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Activated += (_, __) =>
        {
            Program.Stopwatch.Stop();
            Console.WriteLine($"Activated in {Program.Stopwatch.ElapsedMilliseconds}ms");

            var buttonsPaneMap = new Dictionary<string, UserControl>
            {
                { "RocketsButton", new RocketsPane() },
                { "LogsButton", new LogsPane() },
                { "SettingsButton", new SettingsPane() }
            };
            foreach (var buttonName in buttonsPaneMap.Keys)
            {
                this.FindControl<Button>(buttonName)!.Click += (_, __) => this.FindControl<ContentControl>("MainSidebarContent")!.Content = buttonsPaneMap[buttonName];
            }

            this.FindControl<ContentControl>("LeftContent")!.Content = new MapContent();
            this.FindControl<ContentControl>("RightTopContent")!.Content = new RealtimeDataContent();
            this.FindControl<ContentControl>("RightBottomContent")!.Content = new PlotsContent();
        };
    }
}
