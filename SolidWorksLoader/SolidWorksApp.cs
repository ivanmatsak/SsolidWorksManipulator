using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SolidWorksLoader
{
    public class SolidWorksApp
    {
        //SldWorks
        public object _activeApp;

        public object COSMOSWORKS;

        public object swMathUtils;

        //ModelDoc2
        private object _activeDoc;

        //ModelView
        private object modelView;

        public object swApp
        {
            get { return _activeApp; }
            set
            {
                _activeApp = value;

                if (_activeApp != null)
                {
                    swMathUtils = (_activeApp as SldWorks).GetMathUtility();
                }

            }
        }

        public object swDoc
        {
            get { return _activeDoc; }
            set
            {
                _activeDoc = value;

                if (_activeDoc != null) {
                    modelView = (_activeDoc as ModelDoc2).ActiveView;
                }
                
            }
        }

        //Отключает геометрическую проверку(совпадение точек, параллельность прямых и тд) и добавляет созданные элементы в базу данных 
        public void EnableAddToDB()
        {
            (_activeDoc as ModelDoc2).SketchManager.AddToDB = true;
        }
        //Включает геометрическую проверку(совпадение точек, параллельность прямых и тд) и добавляет созданные элементы в базу данных 
        public void DisableAddToDB()
        {
            (_activeDoc as ModelDoc2).SketchManager.AddToDB = false;
        }

        //Включает графическое отображения обьектов(эскизи, сущности и тд) на экране
        public void EnableDisplayWhenAdded()
        {
            (_activeDoc as ModelDoc2).SketchManager.DisplayWhenAdded = true;
        }

        //Отключает графическое отображения обьектов(эскизи, сущности и тд) на экране
        public void DisableDisplayWhenAdded()
        {
            (_activeDoc as ModelDoc2).SketchManager.DisplayWhenAdded = false;
        }

        //Включает обновление дерева обьектов
        public void EnableFeatureTree()
        {
            (_activeDoc as ModelDoc2).FeatureManager.EnableFeatureTree = true;
            (_activeDoc as ModelDoc2).FeatureManager.EnableFeatureTreeWindow = true;
        }

        //Отключает обновление дерева обьектов
        public void DisableFeatureTree()
        {
            (_activeDoc as ModelDoc2).FeatureManager.EnableFeatureTree = false;
            (_activeDoc as ModelDoc2).FeatureManager.EnableFeatureTreeWindow = false;
        }

        //Заблокировать пользовательский интерфейс
        public void EnableFullBlockingStates() {
            (_activeDoc as ModelDoc2).SetBlockingState((int)swBlockingStates_e.swFullBlock);
        }

        //Разблокировать пользовательский интерфейс
        public void DisableFullBlockingStates()
        {
            (_activeDoc as ModelDoc2).ResetBlockingState();
        }

        //Включает обновление графического окна
        public void EnableGraphicsUpdate() {
            (modelView as ModelView).EnableGraphicsUpdate = true;
        }

        //Отключает обновление графического окна
        public void DisableGraphicsUpdate() {
            (modelView as ModelView).EnableGraphicsUpdate = false;
        }

        //Включает контроль над приложение SoldiWorks для пользователя
        public void EnableUserControlBackground()
        {
            (_activeApp as SldWorks).UserControlBackground = true;
        }

        //Отключает контроль над приложение SoldiWorks для пользователя
        public void DisableUserControlBackground()
        {
            (_activeApp as SldWorks).UserControlBackground = false;
        }

        //Включить ускорение создание обьектов
        public void EnableAcceleration() {
            EnableAddToDB();
            DisableDisplayWhenAdded();
            DisableFeatureTree();
            EnableFullBlockingStates();
            DisableGraphicsUpdate();
            DisableUserControlBackground();
        }

        //Отключить ускорение создание обьектов
        public void DisableAcceleration()
        {
            DisableAddToDB();
            EnableDisplayWhenAdded();
            EnableFeatureTree();
            DisableFullBlockingStates();
            EnableGraphicsUpdate();
            EnableUserControlBackground();
        }

        //Получить путь к файлам с материалами
        public string[] GetPathsMaterialDataBase() {

            object[] result = (_activeApp as SldWorks).GetMaterialDatabases();

            return result.Cast<string>().ToArray();
        }
    }

}
