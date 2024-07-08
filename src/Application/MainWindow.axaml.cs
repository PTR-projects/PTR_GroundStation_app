using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;
using System.Collections.Generic;

namespace PTR.GroundStation;

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
            foreach(var buttonName in buttonsPaneMap.Keys)
            {
                this.FindControl<Button>(buttonName).Click += (_, __) => this.FindControl<ContentControl>("PaneContentArea").Content = buttonsPaneMap[buttonName];
            }
        };
    }
}
