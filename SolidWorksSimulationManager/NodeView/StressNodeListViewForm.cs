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
    public partial class StressNodeListViewForm : Form
    {
        private StressNodeListView stressListView;

        private StaticStudyResults results;

        private string checkParam = "SX";

        public StressNodeListViewForm(StaticStudyResults results)
        {
            InitializeComponent();

            this.results = results;

            this.stressListView = new StressNodeListView(this.listViewStress, results.nodes);

            radioButtonSX.Checked = true;

            timerCalculate.Start();

        }

        private void Calculate(string param) {

            Node node = stressListView.GetSelectedItem();
            if (node != null)
            {

                float value = stressListView.GetParam(node, param);
                float max = (100f + (float)numericUpDownMax.Value) / 100;
                float min = (100f - (float)numericUpDownMin.Value) / 100;
                float offsetMax = value * max;
                float offsetMin = value * min;

                textBoxNodeValue.Text = value.ToString();
                labelNodeNumberTitle.Text = "Узел " + node.number.ToString();

                labelMax.Text = offsetMax.ToString();
                labelMin.Text = offsetMin.ToString();
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            checkParam = radioButton.Text;

            if (radioButton.Checked) {

                labelSelectParam.Text = checkParam;
                Calculate(checkParam);

            }

        }

        private void timerCalculate_Tick(object sender, EventArgs e)
        {
            Calculate(checkParam);
        }

        private void buttonFindArea_Click(object sender, EventArgs e)
        {
            float offsetMax;
            float offsetMin;

            IEnumerable<Node> rangeNodes;

            HashSet<Element> findArea = new HashSet<Element>();

            try
            {

                offsetMax = (float)Convert.ToDouble(labelMax.Text);

                offsetMin = (float)Convert.ToDouble(labelMin.Text);

                rangeNodes = stressListView.GetRange(checkParam, offsetMin, offsetMax);
              

                ElementViewForm elementForm = new ElementViewForm(results.GetElements(rangeNodes));
                elementForm.ShowDialog();

            }
            catch (Exception error)
            {
                MessageBox.Show("Неправильный ввод параметров!", "Ошибка поиска областей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonFindMinimum_Click(object sender, EventArgs e)
        {
            Node node = results.nodes.First();
            if (node != null)
            {
                float minimum = node.stress.GetParam(checkParam);
                float currentValue;

                foreach(Node it in results.nodes)
                {
                    currentValue = it.stress.GetParam(checkParam);
                    if (currentValue < minimum)
                        minimum = currentValue;
                }
                textBoxNodeValue.Text = minimum.ToString();
            }
        }
    }
}
