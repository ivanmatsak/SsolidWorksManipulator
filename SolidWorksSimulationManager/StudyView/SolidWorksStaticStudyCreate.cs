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
    public partial class SolidWorksStaticStudyCreate : Form
    {

        public StaticStudyRecord record;

        private StudyMesh mesh;

        private SolidWorksMaterialManager.Material material;

        private IEnumerable<StudyFace> loadFace;

        private IEnumerable<StudyFace> fixFace;

        private SolidWorksFaceManager.FeatureFaceManager FFM;

        private SolidWorksMaterialManager.MaterialManager MM;

        private SolidWorksFaceManager.ColorListBox listFixFace;

        private SolidWorksFaceManager.ColorListBox listLoadFace;

        private SolidWorksFaceManager.FeatureFaceManager FFM_FixFace;

        private SolidWorksFaceManager.FeatureFaceManager FFM_LoadFace;

        public SolidWorksStaticStudyCreate(SolidWorksFaceManager.FeatureFaceManager FFM, SolidWorksMaterialManager.MaterialManager MM)
        {

            InitializeComponent();

            this.FFM = FFM;

            this.MM = MM;

            FFM_FixFace = new SolidWorksFaceManager.FeatureFaceManager();

            FFM_LoadFace = new SolidWorksFaceManager.FeatureFaceManager();

            listFixFace = new SolidWorksFaceManager.ColorListBox(listBoxFixFace, FFM_FixFace);

            listLoadFace = new SolidWorksFaceManager.ColorListBox(listBoxLoadFace, FFM_LoadFace);

        }

        private void FillMaterialСharacteristics(SolidWorksMaterialManager.Material material)
        {

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

        private void FillListBox()
        {

            listFixFace.FillListBoxFreeFaces();
            listLoadFace.FillListBoxFreeFaces();
        }

        private void buttonGetMaterial_Click(object sender, EventArgs e)
        {

            SolidWorksMaterialManager.SolidWorksMaterialSelectForm materialForm = new SolidWorksMaterialManager.SolidWorksMaterialSelectForm(MM);

            materialForm.ShowDialog();

            if (materialForm.selectedMaterial != null) {

                material = materialForm.selectedMaterial;

                FillMaterialСharacteristics(material);

            }
        }

        private void buttonGetLoadFace_Click(object sender, EventArgs e)
        {

            SolidWorksForceManager loadFaceForm = new SolidWorksForceManager(FFM);

            loadFaceForm.ShowDialog();

            if (loadFaceForm.loadFaces != null) {

                FFM_LoadFace.SetFaces(loadFaceForm.loadFaces);

                FFM.LoadFeatureFaces(loadFaceForm.loadFaces);

            }

            FillListBox();

        }

        private void buttonClearForce_Click(object sender, EventArgs e)
        {
            foreach (SolidWorksFaceManager.FeatureFace face in FFM_LoadFace.freeFaces)
            {
                face.name = GetName(face.name);
            }

            FFM.ReleaseFeatureFaces(FFM_LoadFace.freeFaces);

            FFM_LoadFace.ClearFreeFaces();

            FillListBox();

        }

        private void buttonGetFixFace_Click(object sender, EventArgs e)
        {

            SolidWorksFaceManager.SolidWorksFeatureFaceSelectForm faceForm = new SolidWorksFaceManager.SolidWorksFeatureFaceSelectForm(FFM);

            faceForm.ShowDialog();

            if (faceForm.selectedFeatureFaces != null) {

                FFM.LoadFeatureFaces(faceForm.selectedFeatureFaces);

                FFM_FixFace.SetFaces(faceForm.selectedFeatureFaces);


            }

            FillListBox();
        }

        private void buttonClearFix_Click(object sender, EventArgs e)
        {

            FFM.ReleaseFeatureFaces(FFM_FixFace.freeFaces);

            FFM_FixFace.ClearFreeFaces();

            FillListBox();

        }

        private void buttonCreateStudy_Click(object sender, EventArgs e)
        {
            bool error = false;

            string errorMsg = "";

            if (FFM_FixFace.freeFaces.Count == 0) {
                errorMsg += "Не выбраны грани для нагрузки !\n";
                error = true;
            }

            if (FFM_LoadFace.freeFaces.Count == 0) {
                errorMsg += "Не выбраны грани для фиксации !\n";
                error = true;
            }

            if (material == null) {
                errorMsg += "Не выбран материал !\n";
                error = true;
            }

            if (error)
            {
                MessageBox.Show(errorMsg, "Ошибка создания исследования!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                mesh = GetStudyMesh();

                FFM.ReleaseFeatureFaces(FFM.busyFaces);

                loadFace = GetStudyLoadFace(FFM_LoadFace.freeFaces);

                fixFace = GetStudyFixFace(FFM_FixFace.freeFaces);

                record = new StaticStudyRecord(material, fixFace, loadFace, mesh);

                Close();
            }

        }

        private IEnumerable<StudyFace> GetStudyLoadFace(IEnumerable<SolidWorksFaceManager.FeatureFace> faces) {

            HashSet<StudyFace> result = new HashSet<StudyFace>();

            foreach (SolidWorksFaceManager.FeatureFace face in faces)
            {



                string text = GetName(face.name);

                double value = GetForce(face.name);

                face.name = text;

                StudyFace studyFace = new StudyFace(face, value);

                result.Add(studyFace);

            }

            return result;
        }

        private IEnumerable<StudyFace> GetStudyFixFace(IEnumerable<SolidWorksFaceManager.FeatureFace> faces)
        {

            HashSet<StudyFace> result = new HashSet<StudyFace>();

            foreach (SolidWorksFaceManager.FeatureFace face in faces)
            {

                StudyFace studyFace = new StudyFace(face, 0);

                result.Add(studyFace);

            }

            return result;
        }

        private StudyMesh GetStudyMesh() {

            double averageGlobalElementSize = Convert.ToDouble(textBoxGlobalElementSize.Text);
            double tolerance = Convert.ToDouble(textBoxTolerance.Text);

            return new StudyMesh(averageGlobalElementSize, tolerance);
        }

        private double GetForce(string text)
        {

            double result = 0;

            string value = text.Split('-')[1];

            result = Convert.ToDouble(value);

            return result;

        }

        private string GetName(string text)
        {

            return text.Split('-')[0];

        }

    }
}
