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
    public partial class SolidWorksForceManager : Form
    {
        private SolidWorksFaceManager.FeatureFaceManager FFM;

        private SolidWorksFaceManager.FeatureFaceManager FFM_listFace;

        private SolidWorksFaceManager.FeatureFaceManager FFM_listForce;

        private SolidWorksFaceManager.ColorListBox listFaces;

        private SolidWorksFaceManager.ColorListBox listForces;

        
        public IEnumerable<SolidWorksFaceManager.FeatureFace> loadFaces;

        public SolidWorksForceManager(SolidWorksFaceManager.FeatureFaceManager FFM)
        {
            InitializeComponent();

            this.FFM = FFM;

            FFM_listFace = new SolidWorksFaceManager.FeatureFaceManager();

            FFM_listForce = new SolidWorksFaceManager.FeatureFaceManager();

            listFaces = new SolidWorksFaceManager.ColorListBox(listBoxSelectedFaceForLoad, FFM_listFace);
            
            listForces = new SolidWorksFaceManager.ColorListBox(listBoxLoadFace, FFM_listForce);
        
        }

        private void buttonSelectFaceItems_Click(object sender, EventArgs e)
        {

            SolidWorksFaceManager.SolidWorksFeatureFaceSelectForm faceSelectForm = new SolidWorksFaceManager.SolidWorksFeatureFaceSelectForm(FFM);

            faceSelectForm.ShowDialog();

            if (faceSelectForm.selectedFeatureFaces != null)
            {

                FFM_listFace.AddFaces(faceSelectForm.selectedFeatureFaces);
                listFaces.FillListBoxFreeFaces();

                FFM.LoadFeatureFaces(faceSelectForm.selectedFeatureFaces);

                
            }

        }

        private void buttonClearFaceList_Click(object sender, EventArgs e)
        {

            FFM.ReleaseFeatureFaces(FFM_listFace.freeFaces);
            FFM_listFace.ClearFreeFaces();

            listFaces.FillListBoxFreeFaces();
            listForces.FillListBoxFreeFaces();

        }

        private void buttonLoadFaces_Click(object sender, EventArgs e)
        {
            double force = Convert.ToDouble(textBoxForceValue.Text);

            IEnumerable<SolidWorksFaceManager.FeatureFace> faces = listFaces.GetSelectedFaces();

            foreach (SolidWorksFaceManager.FeatureFace face in faces) {
                face.name += "-" + force;
            }

            FFM_listForce.AddFaces(faces);
            FFM_listFace.LoadFeatureFaces(faces);

            listForces.FillListBoxFreeFaces();
            listFaces.FillListBoxFreeFaces();

        }

        private void buttonLoadAllFaces_Click(object sender, EventArgs e)
        {
            double force = Convert.ToDouble(textBoxForceValue.Text);
            foreach (SolidWorksFaceManager.FeatureFace face in FFM_listFace.freeFaces)
            {
                face.name += "-" + force;
            }

            FFM_listForce.AddFaces(FFM_listFace.freeFaces);
            FFM_listFace.LoadFeatureFaces(FFM_listFace.freeFaces);

            listForces.FillListBoxFreeFaces();
            listFaces.FillListBoxFreeFaces();
        }

        private void buttonRemoveSelectForce_Click(object sender, EventArgs e)
        {
            IEnumerable<SolidWorksFaceManager.FeatureFace> faces = listForces.GetSelectedFaces();

            foreach (SolidWorksFaceManager.FeatureFace face in faces)
            {
                face.name = GetName(face.name);
            }

            FFM_listForce.RemoveFreeFaces(faces);
            FFM_listFace.ReleaseFeatureFaces(faces);

            listForces.FillListBoxFreeFaces();
            listFaces.FillListBoxFreeFaces();
        }

        private void buttonClearForceList_Click(object sender, EventArgs e)
        {
            foreach (SolidWorksFaceManager.FeatureFace face in FFM_listForce.freeFaces)
            {
                face.name = GetName(face.name);
            }

            FFM_listFace.ReleaseFeatureFaces(FFM_listForce.freeFaces);
            FFM_listForce.ClearFreeFaces();

            listFaces.FillListBoxFreeFaces();
            listForces.FillListBoxFreeFaces();

        }

        private string GetName(string text)
        {

            return text.Split('-')[0];

        }

        private void buttonForceSave_Click(object sender, EventArgs e)
        {
            buttonClearFaceList_Click(null,null);

            loadFaces = FFM_listForce.freeFaces;

            Close();
        }
    }
}
