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
    public partial class SolidWorksStaticStudyViewForm : Form
    {

        private SolidWorksFaceManager.ColorListBox listFixFace;

        private SolidWorksFaceManager.ColorListBox listLoadFace;

        private SolidWorksFaceManager.FeatureFaceManager FFM_FixFace;

        private SolidWorksFaceManager.FeatureFaceManager FFM_LoadFace;

        public SolidWorksStaticStudyViewForm(StaticStudyRecord record)
        {
            InitializeComponent();

            FFM_FixFace = new SolidWorksFaceManager.FeatureFaceManager(record.fixFaces);

            foreach (StudyFace sFace in record.loadFaces) {
                sFace.name = sFace.name + "-" + sFace.force;
            }


            FFM_LoadFace = new SolidWorksFaceManager.FeatureFaceManager(record.loadFaces);

            listFixFace = new SolidWorksFaceManager.ColorListBox(listBoxFixFace, FFM_FixFace);

            listLoadFace = new SolidWorksFaceManager.ColorListBox(listBoxLoadFace, FFM_LoadFace);

            FillMaterial(record.material);
            FillFace(listFixFace);
            FillFace(listLoadFace);
            FillMesh(record.mesh);

        }

        private void FillFace(SolidWorksFaceManager.ColorListBox listBox) {
            listBox.FillListBoxFreeFaces();
        }


        private void FillMaterial(SolidWorksMaterialManager.Material material) {
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

        private void FillMesh(StudyMesh mesh) {
            textBoxGlobalElementSize.Text = mesh.averageGlobalElementSize.ToString();
            textBoxTolerance.Text = mesh.tolerance.ToString();
        }
    }
}
