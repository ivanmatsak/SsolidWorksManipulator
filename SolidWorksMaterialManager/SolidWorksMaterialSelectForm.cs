using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidWorksMaterialManager
{
    public partial class SolidWorksMaterialSelectForm : Form
    {
        private MaterialManager MM;

        public Material selectedMaterial;

        public SolidWorksMaterialSelectForm(MaterialManager MM)
        {
            InitializeComponent();

            this.MM = MM;

            this.selectedMaterial = null;

            treeViewMaterials.Nodes.AddRange( MM.GetTreeNodeView() );
        }

        private void FillMaterialСharacteristics(Material material) {

            textBoxCategoryName.Text = material.category;

            textBoxMaterialName.Text = material.name;

            textBoxEX.Text = material.physicalProperties["EX"].ToString();
            textBoxNUXY.Text = material.physicalProperties["NUXY"].ToString();
            textBoxGXY.Text = material.physicalProperties["GXY"].ToString();
            textBoxALPX.Text = material.physicalProperties["ALPX"].ToString();
            textBoxDENS.Text = material.physicalProperties["DENS"].ToString();
            textBoxKX.Text = material.physicalProperties["KX"].ToString();
            textBoxC.Text = material.physicalProperties["C"].ToString();
            textBoxSIGXT.Text = material.physicalProperties["SIGXT"].ToString();
            textBoxSIGYLD.Text = material.physicalProperties["SIGYLD"].ToString();

        }

        private void treeViewMaterials_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode parentNode = e.Node.Parent;

            if (parentNode != null)
            {
                string materialName = e.Node.Text;
                
                Material material = MM.materials[materialName];

                FillMaterialСharacteristics(material);

                selectedMaterial = material;


            }

        }

        private void buttonGetMaterial_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
