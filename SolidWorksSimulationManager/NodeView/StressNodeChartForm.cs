using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace SolidWorksSimulationManager
{
    public partial class StressNodeChartForm : Form
    {

        private List<Node> nodes;

        private StressScrollLiveChart scrollChart;

        public StressNodeChartForm(IEnumerable<Node> nodes)
        {
            InitializeComponent();

            this.nodes = nodes.ToList();

            scrollChart = new StressScrollLiveChart(
                cartesianChartStress,
                hScrollBarStress,
                this.nodes,
                30);

            FillCheckBoxList(checkedListBoxParamStress, this.nodes[0].stress.GetParameters().Keys);

          
        }

        private void checkedListBoxParamStress_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = (CheckedListBox)sender;

            string param = clb.Items[e.Index].ToString();


            if (e.NewValue == CheckState.Checked)
            {
                scrollChart.ShowSeries(param);
            }
            else
            {
                scrollChart.HideSeries(param);
            }

        }

        private void FillCheckBoxList(CheckedListBox list, IEnumerable<string> names)
        {

            foreach (string name in names)
            {

                list.Items.Add(name, false);

            }

            list.SetItemChecked(0, true);
        }
      
    }
}
