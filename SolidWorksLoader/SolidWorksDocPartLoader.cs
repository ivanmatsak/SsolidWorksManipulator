using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SolidWorksLoader
{
    class SolidWorksDocPartLoader
    {
        private const int docPartType = (int)swDocumentTypes_e.swDocPART;
        
        public object getActiveDocument(object swApp)
        {
            SldWorks app = swApp as SldWorks;

            ModelDoc2 swDoc = app.ActiveDoc;

            if (swDoc != null && swDoc.GetType() != docPartType) {
                swDoc = null;
            }


            return swDoc;
        }

        public object openDoc(object swApp,string path)
        {
            SldWorks app = swApp as SldWorks;

            int fileError = default(int);
            int fileWarning = default(int);

            //Open doc
            ModelDoc2 swDoc = app.OpenDoc6(
                path,
                (int)swDocumentTypes_e.swDocPART,
                (int)swOpenDocOptions_e.swOpenDocOptions_Silent,
                null,
                ref fileError,
                ref fileWarning
            );


            if (swDoc != null) {
                //Set the working directory to the document directory
                string pathName = swDoc.GetPathName();
                app.SetCurrentWorkingDirectory(pathName.Substring(0, pathName.LastIndexOf("\\")));
            }

            //List<object> features = new List<object>();

            //object[] swFeatures = swDoc.FeatureManager.GetFeatures(true);
            ////swDoc.FeatureManager.Feature
            //features.AddRange(swFeatures);

            return swDoc;
        }

        public object createDoc(object swApp)
        {
            SldWorks app = swApp as SldWorks;

            //@"C:\ProgramData\SolidWorks\SOLIDWORKS 2016\templates\gost-part.prtdot"
            string pathTemplatePart = app.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swFileLocationsDocumentTemplates);
            pathTemplatePart = pathTemplatePart.Split(';')[0] + "gost-part.prtdot";

            ModelDoc2 swDoc = app.NewDocument(pathTemplatePart, 0, 0, 0);

            return swDoc;
        }
    }
}
