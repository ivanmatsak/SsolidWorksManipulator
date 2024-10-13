using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidWorksLoader
{
    public partial class SolidWorksLoaderForm : Form
    {
        public SolidWorksApp sldApp;
        public SolidWorksLoaderForm()
        {
            InitializeComponent();
        }

        private void buttonApplyAppSettings_Click(object sender, EventArgs e)
        {
            bool autoOpenApp = radioButtonAutoAppCreator.Checked;
            bool autoCreatDoc = radioButtonAutoDocCreator.Checked;
            bool manualOpenDoc = radioButtonManualDocOpen.Checked;

            SolidWorksLoaderStatusForm loadSatus = new SolidWorksLoaderStatusForm(
                ref sldApp, 
                autoOpenApp,
                autoCreatDoc, 
                manualOpenDoc);

            if (loadSatus.ShowDialog() == DialogResult.Cancel )
            {
                if (sldApp != null && sldApp.swApp != null && sldApp.swDoc != null) 
                {
                    Close();
                }
                
            }
        }

        private void groupBoxLoadDocPart_Enter(object sender, EventArgs e)
        {

        }
    }
}
