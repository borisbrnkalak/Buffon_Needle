using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView;
using System.Collections.ObjectModel;

namespace Buffon_Needle
{
    public partial class Form1 : Form
    {
        private ObservableCollection<double> ObservableCollection { get; set; } = new();

        public List<ISeries> LineSeries { get; set; } = new();

        public Form1()
        {
            InitializeComponent();

            LineSeries.Add(new LineSeries<double>
            {
                Values = ObservableCollection,
                Fill = null,
                GeometrySize = 0,

            });

            var yAxis = new Axis
            {
                MinLimit = 3,
                MaxLimit = 4,
                Name = "PI Value",
            };

            var xAxis = new Axis
            {
                Name = "Attempts x1000",
            };

            chart.YAxes = new List<Axis> { yAxis };
            chart.XAxes = new List<Axis> { xAxis };

            chart.Series = LineSeries;
        }

        private void startSimulation_Click(object sender, EventArgs e)
        {
            ObservableCollection.Clear();
            int succeed = 0;
            int count = Int32.Parse(inputCount.Text);
            double pi = 0;

            Random random = new Random();

            double L = Int32.Parse(inputLength.Text);
            double D = Int32.Parse(inputGap.Text);

            for (int i = 0; i < count; i++)
            {
                double a = random.NextDouble() * D;
                double alfa = random.NextDouble() * Math.PI;

                double y = L * Math.Sin(alfa);

                if ((a + y) >= D)
                {
                    succeed++;
                }

                if (i % 1000 == 0)
                {
                    pi = (double)(2 * L * i) / (D * Math.Max(succeed, 1));
                    ObservableCollection.Add(pi);
                }
            }
            pi = (double)(2 * L * count) / (D * succeed);
            piValue.Text = pi.ToString();

        }
    }
}