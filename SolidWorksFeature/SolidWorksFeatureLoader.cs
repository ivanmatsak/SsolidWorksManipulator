using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SolidWorksFeature
{

    class SolidWorksFeatureLoader
    {
        
        public List<Feature> GetFeatures(object swDoc) {

            ModelDoc2 doc = swDoc as ModelDoc2;

            List<Feature> features = new List<Feature>();

            Feature[] swFeatures = doc.FeatureManager.GetFeatures(true);

            //features.AddRange(swFeatures);


            return features;
        }

    }
}
