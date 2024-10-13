using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace SolidWorksSimulationManager
{
    public abstract class ScrollLiveChart
    {
        public Dictionary<string, LineSeries> series;

        public Dictionary<int, List<Node>> nodeGroups;

        private List<Node> nodes;

        private LiveCharts.WinForms.CartesianChart chart;

        private HScrollBar scroll;

        protected int countViewNode;

        public ScrollLiveChart(LiveCharts.WinForms.CartesianChart chart, HScrollBar scroll, List<Node> nodes,int countViewNode) {

            this.chart = chart;

            this.scroll = scroll;

            this.nodes = nodes;

            this.countViewNode = countViewNode;

            this.nodeGroups = GetNodeGroups(this.nodes, this.countViewNode);

            this.series = new Dictionary<string, LineSeries>();

            //CreateParamSeries(nodes[0].);

            SetLiveChartSettings(this.countViewNode);

            SetScrollSettings(this.nodeGroups.Count);
        }

        private void SetLiveChartSettings( int countViewNode) {

            Axis axisX = new Axis
            {
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                },
            };

            axisX.MaxValue = countViewNode;
            axisX.MinValue = 0;

            Axis axisY = new Axis
            {
                Separator = new Separator
                {
                    StrokeThickness = 1,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            };

            chart.AxisX.Clear();
            chart.AxisX.Add(axisX);

            chart.AxisY.Clear();
            chart.AxisY.Add(axisY);

            chart.DisableAnimations = true;
        }

        private void SetScrollSettings(int countGroups) {
            scroll.Maximum = countGroups;
            scroll.Minimum = 1;

            scroll.Value = 1;
            scroll.SmallChange = 1;
            scroll.LargeChange = 1;

            scroll.Scroll += new System.Windows.Forms.ScrollEventHandler(ScrollEvenet);
        }

        private static Dictionary<int, List<Node>> GetNodeGroups(List<Node> nodes, int countViewNode) {

            int groups = nodes.Count / countViewNode;
            int last = nodes.Count - groups * countViewNode;

            Dictionary<int, List<Node>> nodeGroups = new Dictionary<int, List<Node>>();

            for (int i = 0; i < groups; i++)
            {

                nodeGroups.Add(
                    i + 1,
                    nodes.GetRange(i * countViewNode, countViewNode)
                    );
            }

            nodeGroups[groups].AddRange(nodes.GetRange(groups * countViewNode, last));

            return nodeGroups;
        }

        private LineSeries CreateSeries(string name) {

            LiveCharts.Wpf.LineSeries series = new LineSeries();

            series.Title = name;

            series.Fill = System.Windows.Media.Brushes.Transparent;

            return series;
        }

        public void CreateParamSeries(string[] param) {

            series.Clear();

            foreach (string name in param) {

                LineSeries newSeries = CreateSeries(name);

                series.Add(name, newSeries);

                chart.Series.Add(newSeries);

                HideSeries(name);
            }

        }

        public void FillAllSeries(int viewGroup) {

            foreach (string name in series.Keys) {

                FillSeries(name,viewGroup);

            }

        }

        public abstract void FillSeries(string name, int viewGroup);

        public void ScrollChart(int viewGroup, int countViewNode) {

            chart.AxisX[0].MaxValue = viewGroup * countViewNode  - 1;

            chart.AxisX[0].MinValue = chart.AxisX[0].MaxValue - countViewNode + 1;

        }

        public void ShowSeries(string name)
        {

            series[name].Visibility = System.Windows.Visibility.Visible;
        }

        public void HideSeries(string name)
        {
            series[name].Visibility = System.Windows.Visibility.Hidden;
        }

        private void ScrollEvenet(object sender, ScrollEventArgs e) {

            ScrollChart(e.NewValue, countViewNode);

            FillAllSeries(e.NewValue);

        }

    }
}
