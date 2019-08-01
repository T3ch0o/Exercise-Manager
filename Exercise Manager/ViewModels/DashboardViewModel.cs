namespace Exercise.Manager.ViewModels
{
    using System;
    using System.Linq;
    using System.Windows.Media;
    using Interfaces;
    using LiveCharts;
    using LiveCharts.Defaults;
    using LiveCharts.Wpf;

    public class DashboardViewModel : ViewModelBase, IDashboardViewModel
    {
        public DashboardViewModel(IWeeklyGraphViewModel weeklyGraph)
        {
            WeeklyGraph = weeklyGraph;

            SetWeeklyGraphData();
            ConfigureGraphLabels();
            ConfigureGraphStyles();
        }

        private void SetWeeklyGraphData()
        {
            SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Values = new ChartValues<ObservableValue>
                    {
                        new ObservableValue(4),
                        new ObservableValue(2),
                        new ObservableValue(8),
                        new ObservableValue(2),
                        new ObservableValue(3),
                        new ObservableValue(10),
                        new ObservableValue(10)
                    },
                    DataLabels = true,
                    LabelPoint = point => point.Y + " h"
                }
            };
        }

        private void ConfigureGraphStyles()
        {
            SeriesCollection.OfType<ColumnSeries>().ToList().FirstOrDefault().Foreground = Brushes.White;
            SeriesCollection.OfType<ColumnSeries>().ToList().FirstOrDefault().Fill = new SolidColorBrush(Color.FromRgb(192, 192, 0));
        }

        private void ConfigureGraphLabels()
        {
            Labels = new[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Formatter = value => value + " h";
        }

        public SeriesCollection SeriesCollection { get; set; }

        public string[] Labels { get; set; }

        public Func<double, string> Formatter { get; set; }

        public string Title { get; } = "Dashboard";

        public IWeeklyGraphViewModel WeeklyGraph { get; }
    }
}
