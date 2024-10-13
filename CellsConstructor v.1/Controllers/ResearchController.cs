using SolidWorksLoader;
using SolidWorksSimulationManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main._1.Controllers
{
    public class ResearchController
    {
        public static StaticStudyResults RunResearch(StudyManager studyManager, StaticStudyRecord studyRecord)
        {
            StaticStudyResults result = null;

            try
            {
                var study = studyManager.CreateStudy(studyRecord);
                int error = study.RunStudy();

                result = error == 0
                    ? study.GetResult()
                    : throw new Exception(
                        String.Format("Создание исследования провалилось!\nКод ошибки: {0}\n{1}\n",
                        error,
                        studyRecord)
                        );
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                studyManager.ClearAllStudy();
            }

            return result;
        }

        public static void ValidateResearch(SolidWorksApp sldApp, StaticStudyRecord staticStudyRecord)
        {
            if (sldApp == null && sldApp?.swApp == null && sldApp?.swDoc == null)
            {
                throw new Exception("Приложение SolidWorks не загружено!\n");
            }

            if (staticStudyRecord == null)
            {
                throw new Exception("Не выбрано исследование!\n");
            }
        }


    }
}
