using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolidWorksSimulationManager
{
    public class StudyFace : SolidWorksFaceManager.FeatureFace
    {
        public double force;

        public StudyFace(SolidWorksFaceManager.FeatureFace ff, double force) : base(ff.face, ff.name,ff.color)
        {
            this.force = force;
        }

    }
}
