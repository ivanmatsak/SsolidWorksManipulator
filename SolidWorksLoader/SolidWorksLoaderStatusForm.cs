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
    public partial class SolidWorksLoaderStatusForm : Form
    {
        private readonly SolidWorksAppLoader sldAppLoader;
        private readonly SolidWorksDocPartLoader sldDocLoader;
        private readonly SolidWorksApp sldApp;

        private readonly bool autoOpenApp;
        private readonly bool autoCreatDoc;
        private readonly bool manualOpenDoc;

        private delegate void appOpenHandler();
        private event appOpenHandler AppOpen;

        private delegate void appDocHandler();
        private event appOpenHandler DocOpen;

        public SolidWorksLoaderStatusForm(ref SolidWorksApp sldApp,bool autoOpenApp,bool autoCreatDoc,bool manualOpenDoc)
        {
            InitializeComponent();

            sldApp = new SolidWorksApp();

            this.sldApp = sldApp;

            this.autoOpenApp = autoOpenApp;
            this.autoCreatDoc = autoCreatDoc;
            this.manualOpenDoc = manualOpenDoc;

            sldAppLoader = new SolidWorksAppLoader();
            sldDocLoader = new SolidWorksDocPartLoader();

            labelManualInfo.Text = getUserAction();


        }

        private string getUserAction() {
            string result = "";

            if (!autoOpenApp)
            {
                result += "\t- Откройте приложение Solid Works вручную.\n";
            }


            if (manualOpenDoc)
            {
                result += "\t- Самостоятельно откройте или создайте документ типа Part.\n";
            }
            else if (!autoCreatDoc) {
                result += "\t- Задайте путь к нужному документу типа Part.\n";
            }

            if (result.Length != 0) {
                result = "Необходимые действия пользователя:\n" + result;
            }

            return result;
        }
        
        private void TimerFindActiveDoc_Tick(object sender, EventArgs e)
        {
            if (sldApp?.swApp != null)
            {
                if (sldApp?.swDoc == null)
                {
                    sldApp.swDoc = sldDocLoader.getActiveDocument(sldApp?.swApp);
                }
                else
                {
                    timerFindActiveDoc.Stop();
                    DocOpen?.Invoke();
                }
            }
        }

        private void TimerFindActiveApp_Tick(object sender, EventArgs e)
        {
            if (sldApp?.swApp == null)
            {
                sldApp.swApp = sldAppLoader.getSolidWorksActiveApp();

            }
            else {
                timerFindActiveApp.Stop();
                AppOpen?.Invoke();
            }
        }

        private void SolidWorkLoadStatusForm_Load(object sender, EventArgs e)
        {
            AppOpen += LoadDoc;
            DocOpen += LoadCompleted;

            if (autoOpenApp)
            {
                sldApp.swApp = sldAppLoader.OpenSolidWorksApp();
                AppOpen?.Invoke();
            }
            else 
            { 
                timerFindActiveApp.Start();
            }

        }

        private void LoadDoc() {
            labelAppInfo.Text = "Приложение загружено !";
            progressBarAppLoad.Value = progressBarAppLoad.Maximum;

            //Показать SolidWorks
            sldAppLoader.ShowSolidWorksWindow(sldApp.swApp);

            if (autoCreatDoc)
            {
                sldApp.swDoc = sldDocLoader.createDoc(sldApp?.swApp);
                DocOpen?.Invoke();
            }
            else if (manualOpenDoc)
            {
                timerFindActiveDoc.Start();
            }
            else if (openFileDialogDocPart.ShowDialog() == DialogResult.OK)
            {
                sldApp.swDoc = sldDocLoader.openDoc(sldApp?.swApp, openFileDialogDocPart.FileName);

                if (sldApp.swDoc == null)
                {
                    LoadDoc();
                }
                else {
                    DocOpen?.Invoke();
                }
            }
        }

        private void LoadCompleted() {

            labelDocInfo.Text = "Документ загружен !";

            progressBarDocLoad.Value = progressBarDocLoad.Maximum;

            
            sldAppLoader.LoadSimulation(sldApp.swApp);
            sldApp.COSMOSWORKS = sldAppLoader.GetSimulation(sldApp.swApp);

            Close(); 
        }
    }
}
