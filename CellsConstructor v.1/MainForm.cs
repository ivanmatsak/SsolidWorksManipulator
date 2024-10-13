using Main._1.Controllers;
using SolidWorks.Interop.sldworks;
using SolidWorksSimulationManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Main._1
{
    public partial class MainForm : Form
    {

        private SolidWorksFaceManager.FeatureFaceManager FFM;

        private SolidWorksFaceManager.FeatureFaceManager constFFM;

        private SolidWorksMaterialManager.MaterialManager MM;

        private SolidWorksSimulationManager.StudyManager SM;

        private SolidWorksLoader.SolidWorksApp sldApp;

        private CoordinateSystem coordinateSystem;

        private SolidWorksSimulationManager.StaticStudyRecord study;
        public MainForm()
        {
            InitializeComponent();

           
        }

       

        private void toolStripButtonSolidWorksLoad_Click(object sender, EventArgs e)
        {
            SolidWorksLoader.SolidWorksLoaderForm loadForm = new SolidWorksLoader.SolidWorksLoaderForm();

            loadForm.ShowDialog();

            sldApp = loadForm.sldApp;

            if (sldApp != null && sldApp?.swApp != null && sldApp?.swDoc != null)
            {

                ModelDoc2 swDoc = sldApp.swDoc as ModelDoc2;

                MathUtility swMathUtils = sldApp.swMathUtils as MathUtility;
                coordinateSystem = new CoordinateSystem(swMathUtils);

                FFM = new SolidWorksFaceManager.FeatureFaceManager(swDoc);

                constFFM = new SolidWorksFaceManager.FeatureFaceManager(swDoc);

                string[] paths = sldApp.GetPathsMaterialDataBase();
                MM = new SolidWorksMaterialManager.MaterialManager();
                foreach (string path in paths)
                {
                    MM.LoadDBMaterials(path);
                }

                SM = new SolidWorksSimulationManager.StudyManager(sldApp.COSMOSWORKS);

                
            }

        }

        #region [ Reserch ]

        private void RunReserchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticStudyResults results = null;

            try
            {
                var studyRecord = study;

                ResearchController.ValidateResearch(sldApp, studyRecord);



                FFM = new SolidWorksFaceManager.FeatureFaceManager(sldApp.swDoc as ModelDoc2);

                try
                {
                    results = ResearchController.RunResearch(SM, studyRecord);
                }
                catch (Exception error)
                {

                }



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка проведения исследования!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

      

        #endregion


        #region [ Study Item ]

        private void CreateStudyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sldApp != null && sldApp.swApp != null && sldApp.swDoc != null)
            {

                SolidWorksSimulationManager.SolidWorksStaticStudyCreate studyForm = new SolidWorksSimulationManager.SolidWorksStaticStudyCreate(FFM, MM);
                studyForm.ShowDialog();
                study = studyForm.record;

            }
            else
            {
                MessageBox.Show("Приложение SolidWorks не загружено!", "Ошибка проведения исследования!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ViewStudyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (study != null)
             new SolidWorksSimulationManager.SolidWorksStaticStudyViewForm(study).ShowDialog();
             
        }


        #endregion

        #region [ Study Result Item ]

        private void ChartStrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (listBoxStaticResults.SelectedItem != null)
            //{
            //    SolidWorksSimulationManager.StaticStudyResults results = listBoxStaticResults.SelectedItem as SolidWorksSimulationManager.StaticStudyResults;

            //    SolidWorksSimulationManager.StrainNodeChartForm chartForm = new SolidWorksSimulationManager.StrainNodeChartForm(results.nodes);

            //    chartForm.Show();

            //}
        }


        private Dictionary<int, IEnumerable<SolidWorksSimulationManager.Element>> GetGroups(IEnumerable<SolidWorksSimulationManager.Element> elements)
        {


            Dictionary<int, IEnumerable<SolidWorksSimulationManager.Element>> result = new Dictionary<int, IEnumerable<SolidWorksSimulationManager.Element>>();

            Stack<SolidWorksSimulationManager.Element> stack = new Stack<SolidWorksSimulationManager.Element>(elements);


            int level = 0;
            while (stack.Count != 0)
            {

                SolidWorksSimulationManager.Element element = stack.Pop();

                IEnumerable<SolidWorksSimulationManager.Element> adjacent = stack.Where((currentElement) => currentElement.isAdjacent(element));

                stack = new Stack<SolidWorksSimulationManager.Element>(stack.Except(adjacent));

                result[level] = adjacent.Append(element);

                level++;
            }

            return result;
        }


        
        #endregion
    }
}