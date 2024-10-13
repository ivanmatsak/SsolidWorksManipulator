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
    public partial class ElementViewForm : Form
    {

        private ElementListView listView;

        private IEnumerable<Element> elements;

        public ElementViewForm(IEnumerable<Element> elements)
        {
            InitializeComponent();

            this.elements = elements;

            listView = new ElementListView(listViewElemets,elements);
        }

        private void buttonSaveSelectedElements_Click(object sender, EventArgs e)
        {
            ElementBuffer.elements = listView.GetSelectedItems();
            Close();
        }

        public void buttonSaveAllElements_Click(object sender, EventArgs e)
        {
            ElementBuffer.elements = elements;
            Close();
        }

        public void SaveAllElements() {
            ElementBuffer.elements = elements;
        }

        public void SaveSelectedElements()
        {
            ElementBuffer.elements = listView.GetSelectedItems();
        }


    }
}
