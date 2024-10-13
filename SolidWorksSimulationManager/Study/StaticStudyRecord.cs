using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorksSimulationManager
{
    public class StaticStudyRecord
    {
        public readonly string text = "StaticStudy";


        public readonly SolidWorksMaterialManager.Material material;

        public readonly IEnumerable<StudyFace> fixFaces;

        public readonly IEnumerable<StudyFace> loadFaces;

        public readonly StudyMesh mesh;

        public StaticStudyRecord(
            SolidWorksMaterialManager.Material material, 
            IEnumerable<StudyFace> fixFaces,
            IEnumerable<StudyFace> loadFaces, 
            StudyMesh mesh) {

            this.material = material;

            this.fixFaces = fixFaces;

            this.loadFaces = loadFaces;

            this.mesh = mesh;


        }

        public override string ToString()
        {
            string result = String.Format(
                "Исследование:{0} Материал:{1}",
                text,material);

            return result;
        }

    }
}
