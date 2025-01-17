﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SolidWorks.Interop.cosworks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SolidWorksSimulationManager
{
    public class StaticStudy
    {

        private CWStudy study;

        private ICWMesh mesh;

        private CWSolidManager solidManager;

        private ICWLoadsAndRestraintsManager restraintsManager;

        private CWSolidBody[] solidBodies;

        private List<ICWRestraint> fixedFaces;

        private List<CWForce> loadedFaces;

        private StaticStudyRecord record;

        private static swsLinearUnit_e LINEAR_UNIT = swsLinearUnit_e.swsLinearUnitMillimeters;

        public StaticStudy(CWStudy study, StaticStudyRecord record) {

            this.study = study;

            this.solidManager = study.SolidManager;

            this.restraintsManager = study.LoadsAndRestraintsManager;

            this.solidBodies = GetSolidBodies(this.solidManager);

            this.fixedFaces = new List<ICWRestraint>();

            this.loadedFaces = new List<CWForce>();

            this.record = record;

            LoadMaterial(record.material);

            int errorMesh = 0;
            int errorFix = 0;
            int errorLoad = 0;

            errorMesh = CreateMesh(record.mesh);
            errorFix = FixFaces(record.fixFaces.ToArray());
            errorLoad = LoadFaces(record.loadFaces.ToArray());

            StudyErrors(errorMesh, errorFix, errorLoad);
        }

        private static void StudyErrors(int errorMesh,int errorFix,int errorLoad){


            bool error = false;
            string errorMsg = "";
            

            if (errorMesh != 0)
            {
                errorMsg += String.Format("Ошибка создания сетки : {0} !", errorMesh) + "\n";
                error = true;
            }


            if (errorFix != 0)
            {
                errorMsg += String.Format("Ошибка фикации сторон : {0} !", errorFix) + "\n";
                error = true;
            }

            if (errorLoad != 0)
            {
                errorMsg += String.Format("Ошибка нагрузки сторон : {0} !", errorLoad) + "\n";
                error = true;
            }

            if (error) {

                throw new Exception(errorMsg);

            }

        }

        public StaticStudy(CWStudy study)
        {

            this.study = study;

            this.solidManager = study.SolidManager;

            this.restraintsManager = study.LoadsAndRestraintsManager;

            this.solidBodies = GetSolidBodies(this.solidManager);

            this.fixedFaces = new List<ICWRestraint>();

            this.loadedFaces = new List<CWForce>();

        }

        public int RunStudy() {

            int errorCode = 0;

            errorCode = study.RunAnalysis();

            return errorCode;

        }

        public StaticStudyResults GetResult() { 
            return new StaticStudyResults(study.Results,mesh);
        }

        public void LoadMaterial(SolidWorksMaterialManager.Material material)
        {

            SetSolidBodyMaterial(this.solidBodies, material);

        }

        public int CreateDefaultMesh()
        {

            double averageGlobalElementSize = 0;

            double tolerance = 0; 

            mesh = (ICWMesh)study.Mesh;

            mesh.Quality = (int)swsMeshQuality_e.swsMeshQualityHigh;

            mesh.GetDefaultElementSizeAndTolerance(
                (int)LINEAR_UNIT,
                out averageGlobalElementSize,
                out tolerance);

            int errorCode = study.CreateMesh(
                (int)LINEAR_UNIT,
                averageGlobalElementSize,
                tolerance);

            return errorCode;
        }

        public int CreateMesh(double averageGlobalElementSize, double tolerance)
        { 

            mesh = (ICWMesh)study.Mesh;

            mesh.Quality = (int)swsMeshQuality_e.swsMeshQualityHigh;


            int errorCode = study.CreateMesh(
                (int)LINEAR_UNIT,
                averageGlobalElementSize,
                tolerance);

            return errorCode;
        }

        public int CreateMesh(StudyMesh stdMesh)
        {
            return CreateMesh(stdMesh.averageGlobalElementSize , stdMesh.tolerance);
        }

        public int FixFaces(StudyFace[] faces)
        {
            object[] objectFaces = ConvertFacesToObjects(faces);

            return FixFaces(fixedFaces,restraintsManager, objectFaces);

        }

        public int LoadFaces(StudyFace[] faces) {

            object[] objectFaces = ConvertFacesToObjects(faces);

            int errorCode = 0;

            foreach (StudyFace face in faces) {

                object[] objFace = new object[] { face.face as object };

                errorCode = LoadFaces(loadedFaces, restraintsManager, objFace, face.force);

            }

            return errorCode;

        }

        private static int FixFaces(List<ICWRestraint> fixedFaces, ICWLoadsAndRestraintsManager restraintsManager, object[] faces)
        {

            int errorCode = 0;

            ICWRestraint restraint = restraintsManager.AddRestraint(
                (int)swsRestraintType_e.swsRestraintTypeFixed,
                faces,
                null,
                out errorCode);

            if (errorCode == 0)
            {
                fixedFaces.Add(restraint);
            }

            return errorCode;
        }

        private static int LoadFaces(List<CWForce> loadedFaces, ICWLoadsAndRestraintsManager restraintsManager, object[] faces, double value)
        {

            int errorCode = 0;

            double[] COMPS = { 1, 1, 1, 1, 1, 1 };
            double[] DIST_VALUE = new double[0];
            double[] FORCE_VALUE = new double[0];
            int UCODE = 0;
            int refForceDirection = -1;
            int notUsed = 0;

            CWForce force = restraintsManager.AddForce3(
                (int)swsForceType_e.swsForceTypeNormal,
                (int)swsSelectionType_e.swsSelectionFaceEdgeVertexPoint,
                refForceDirection,
                notUsed,
                notUsed,
                notUsed,
                DIST_VALUE,
                FORCE_VALUE,
                true,
                false,
                notUsed,
                notUsed,
                UCODE,
                value,
                COMPS,
                false,
                false,
                faces,
                null,
                false,
                out errorCode);

            if (errorCode == 0) {
                loadedFaces.Add(force);
            }

            return errorCode;

        }

        private static void SetSolidBodyMaterial(CWSolidBody[] solidBodies, SolidWorksMaterialManager.Material material) {

            foreach (CWSolidBody solidBody in solidBodies) {

                material.SetCWMaterial(solidBody);

            }

        }

        private static CWSolidBody[] GetSolidBodies(CWSolidManager solidManager) {

            List<CWSolidBody> result = new List<CWSolidBody>();

            int errorCode = 0;

            for (int i = 0; i < solidManager.ComponentCount; i++) {

                CWSolidComponent solidComponent = solidManager.GetComponentAt(i, out errorCode);

                CWSolidBody solidBody = solidComponent.GetSolidBodyAt(0, out errorCode);

                result.Add(solidBody);

            }

          

            //errCode = SolidBody.SetSolidBodyMaterial(material.GetCWMaterial());


            return result.ToArray();
        }

        private object[] ConvertFacesToObjects(SolidWorksFaceManager.FeatureFace[] faces)
        {

            List<object> result = new List<object>();

            foreach (SolidWorksFaceManager.FeatureFace face in faces)
            {

                result.Add(face.face as object);

            }

            return result.ToArray();
        }
    }
}
