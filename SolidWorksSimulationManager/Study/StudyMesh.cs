using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorksSimulationManager
{
    public class StudyMesh
    {

        public readonly double averageGlobalElementSize;

        public readonly double tolerance;

        public StudyMesh(double averageGlobalElementSize, double tolerance) {

            this.averageGlobalElementSize = averageGlobalElementSize;

            this.tolerance = tolerance;
        }


    }
}
