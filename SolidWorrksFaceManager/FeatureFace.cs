using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;


namespace SolidWorksFeature
{
    public class FeatureFace
    {
        public readonly string name;
        
        public readonly Face face;

        private Entity entity;

        public FeatureFace(Face face,string name) {

            this.name = name;

            this.face = face;

            this.entity = face as Entity;

        }

        public void SetRGB(int r,int g, int b) {

            double[] param = face.MaterialPropertyValues;

            if (param == null) {
                param = new double[9];
            }

            param[0] = r;
            param[1] = g;
            param[2] = b;

            face.MaterialPropertyValues = param;
        }

        public int[] GetRGB() {

            double[] param = face.MaterialPropertyValues;

            if (param == null)
            {
                param = new double[9];
            }

            int[] color = new int[] { 
                Convert.ToInt32(param[0]),
                Convert.ToInt32(param[1]),
                Convert.ToInt32(param[2])
            };

            return color;
        }

        public void Select() {
            entity.Select(false);
        }
    }
}
