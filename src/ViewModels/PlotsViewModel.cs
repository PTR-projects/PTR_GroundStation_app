using ReactiveUI;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
namespace PTR.GroundStation.ViewModels;

public class PlotsViewModel : ReactiveObject
{
    public ISeries[] Series { get; set; } = new ISeries[]
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6 },
                    Fill = null
                }
            };
}
