using Avalonia.Controls;
using System;
using System.Linq;
using System.Collections.Generic;
using Avalonia.Interactivity;

namespace PTR.GroundStation.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        buttonsPaneMap = new Dictionary<string, UserControl>
            {
                { "RocketsButton", new RocketsPane() },
                { "LogsButton", new LogsPane() },
                { "SettingsButton", new SettingsPane() }
            }.ToDictionary(x => this.FindControl<Button>(x.Key)!, x => x.Value);
        sidebar = this.FindControl<SplitView>("MainSidebar")!;
        sidebarContent = this.FindControl<ContentControl>("MainSidebarContent")!;

        Initialize();

#if DEBUG
        Program.Stopwatch.Stop();
        Console.WriteLine($"Initialized in {Program.Stopwatch.ElapsedMilliseconds}ms");
#endif
    }

    private void Initialize()
    {
        foreach (var button in buttonsPaneMap.Keys)
        {
            button.Click += PaneButtonClicked;
        }

        this.FindControl<ContentControl>("LeftContent")!.Content = new MapContent();
        this.FindControl<ContentControl>("RightTopContent")!.Content = new RealtimeDataContent();
        this.FindControl<ContentControl>("RightBottomContent")!.Content = new PlotsContent();
    }

    private void PaneButtonClicked(object? sender, RoutedEventArgs e)
    {
        if (sender is not Button button)
        {
            return;
        }

        foreach (var btn in buttonsPaneMap.Keys.Where(x => x != button))
        {
            btn.Classes.Remove(ActiveClass);
        }

        var showPane = !button.Classes.Contains(ActiveClass);
        sidebar.IsPaneOpen = showPane;
        button.Classes.Set(ActiveClass, showPane);
        if (showPane)
        {
            sidebarContent.Content = buttonsPaneMap[button];
        }
    }

    private readonly SplitView sidebar;
    private readonly ContentControl sidebarContent;
    private readonly Dictionary<Button, UserControl> buttonsPaneMap;

    private const string ActiveClass = "Active";
}
