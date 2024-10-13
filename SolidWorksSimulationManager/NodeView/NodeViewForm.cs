using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidWorksSimulationManager
{
    public partial class NodeViewForm : Form
    {
        private StaticStudyResults results;

        public NodeViewForm(StaticStudyResults results)
        {
            InitializeComponent();

            this.results = results;

        }

        private void buttonViewChartStress_Click(object sender, EventArgs e)
        {
            StressNodeChartForm stressChartForm = new StressNodeChartForm(results.nodes);
            stressChartForm.Show();
        }

        private void buttonViewChartStrain_Click(object sender, EventArgs e)
        {

            StrainNodeChartForm strainChartForm = new StrainNodeChartForm(results.nodes);
            strainChartForm.Show();
        }

        private void buttonViewNodeStress_Click(object sender, EventArgs e)
        {

            StressNodeListViewForm stressNodeListViewForm = new StressNodeListViewForm(results);
            stressNodeListViewForm.Show();
        }

        private void buttonViewNodeStrain_Click(object sender, EventArgs e)
        {
            StrainNodeListViewForm strainNodeListViewForm = new StrainNodeListViewForm(results);
            strainNodeListViewForm.Show();

        }
    }
}
