using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

namespace SolidWorksSimulationManager
{
    public partial class StrainNodeChartForm : Form
    {
        private List<Node> nodes;

        private StrainScrollLiveChart scrollChart;

        public StrainNodeChartForm(IEnumerable<Node> nodes)
        {
            InitializeComponent();

            
            this.nodes = nodes.ToList();
            
            scrollChart = new StrainScrollLiveChart(
                cartesianChartStrain,
                hScrollBarStrain,
                this.nodes,
                30);
            
            FillCheckBoxList(checkedListBoxParamStrain, this.nodes[0].strain.GetParameters().Keys);

        }



        private void FillCheckBoxList(CheckedListBox list, IEnumerable<string> names)
        {

            foreach (string name in names)
            {

                list.Items.Add(name, false);

            }

            list.SetItemChecked(0, true);
        }

        private void checkedListBoxParamStrain_ItemCheck(object sender, ItemCheckEventArgs e)
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
    }
}
