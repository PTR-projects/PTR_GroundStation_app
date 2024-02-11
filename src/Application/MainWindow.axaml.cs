using Avalonia.Controls;
using System;

namespace PTR.GroundStation;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Activated += (_, __) => {
            Program.Stopwatch.Stop();
            Console.WriteLine($"Activated in {Program.Stopwatch.ElapsedMilliseconds}ms");
        };
    }
}
