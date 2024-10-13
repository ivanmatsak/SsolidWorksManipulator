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
    public class StressScrollLiveChart : ScrollLiveChart
    {

        public StressScrollLiveChart(LiveCharts.WinForms.CartesianChart chart, HScrollBar scroll, List<Node> nodes, int countViewNode) :base(chart, scroll, nodes, countViewNode)
        {


            base.CreateParamSeries(nodes[0].stress.GetParameters().Keys.ToArray());

            base.FillAllSeries(1);

            base.ScrollChart(1,base.countViewNode);

        }

        public override void FillSeries(string name, int viewGroup) {

            base.series[name].Values = GetStressParam(base.nodeGroups[viewGroup], viewGroup, name);

        }

        private ChartValues<ObservablePoint> GetStressParam(List<Node> nodes,int viewGroup, string param)
        {

            ChartValues<ObservablePoint> result = new ChartValues<ObservablePoint>();

            int x = (viewGroup -1)  * base.countViewNode;

            foreach (Node node in nodes)
            {
                ObservablePoint point = new ObservablePoint(x, node.stress.GetParam(param));
                result.Add(point);
                x++;
            }


            return result;
        }

    }
}
