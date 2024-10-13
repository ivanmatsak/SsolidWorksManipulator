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
    public partial class StrainNodeListViewForm : Form
    {
        public StrainNodeListView strainListView;

        public StaticStudyResults results;

        public string checkParam = "SX";

        public StrainNodeListViewForm(StaticStudyResults results)
        {
            InitializeComponent();

            this.results = results;

            this.strainListView = new StrainNodeListView(this.listViewStrain, results.nodes);

            radioButtonSX.Checked = true;

            timerCalculate.Start();

        }

        public void Calculate(string param)
        {

            Node node = strainListView.GetSelectedItem();
            
            if (node != null)
            {

                float value = strainListView.GetParam(node, param);
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

            if (radioButton.Checked)
            {

                labelSelectParam.Text = checkParam;
                Calculate(checkParam);

            }

        }

        private void timerCalculate_Tick(object sender, EventArgs e)
        {
            Calculate(checkParam);
        }

        public void buttonFindArea_Click(object sender, EventArgs e)
        {
            float offsetMax;
            float offsetMin;

            IEnumerable<Node> rangeNodes;

            try {

                offsetMax = (float)Convert.ToDouble(labelMax.Text);

                offsetMin = (float)Convert.ToDouble(labelMin.Text);

                rangeNodes = strainListView.GetRange(checkParam, offsetMin, offsetMax);


                ElementViewForm elementForm = new ElementViewForm(results.GetElements(rangeNodes));
                elementForm.ShowDialog();

            }
            catch(Exception error) {
                MessageBox.Show("Неправильный ввод параметров!", "Ошибка поиска областей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void buttonFindMinimum_Click(object sender, EventArgs e)
        {
            {
                Node node = results.nodes.First();
                if (node != null)
                {
                    float minimum = node.strain.GetParam(checkParam);
                    float currentValue;

                    foreach (Node it in results.nodes)
                    {
                        currentValue = it.strain.GetParam(checkParam);
                        if (currentValue < minimum)
                            minimum = currentValue;
                    }
                    textBoxNodeValue.Text = minimum.ToString();
                }
            }
        }
        public void FindMinimum() {
            Node node = results.nodes.First();
            if (node != null)
            {
                float minimum = node.strain.GetParam(checkParam);
                float currentValue;

                foreach (Node it in results.nodes)
                {
                    currentValue = it.strain.GetParam(checkParam);
                    if (currentValue < minimum)
                        minimum = currentValue;
                }
                textBoxNodeValue.Text = minimum.ToString();
            }
        }
    }
}
