using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidWorksFaceManager
{
    public partial class SolidWorksFeatureFaceSelectForm : Form
    {
        private ColorListBox colorListBox;

        public IEnumerable<FeatureFace> selectedFeatureFaces;

        public SolidWorksFeatureFaceSelectForm(FeatureFaceManager FFM )
        {
            InitializeComponent();

            colorListBox = new ColorListBox(listBoxSelectFace, FFM);

            colorListBox.FillListBoxFreeFaces();

        }

      
        private void buttonSelectFaces_Click(object sender, EventArgs e)
        {

            selectedFeatureFaces = colorListBox.GetSelectedFaces();
            if (selectedFeatureFaces.Count() != 0) {
                selectedFeatureFaces.First().Select();
            }
            Close();

        }

    }
}
