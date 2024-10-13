using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.cosworks;


namespace SolidWorksLoader
{
    /// <summary>
    /// Класс SolidWorksAppLoader
    /// Отвечает за запуск приложения Solid Works и загрузку пакета Simulation.
    /// </summary>
    class SolidWorksAppLoader
    {
        /// <summary>
        /// Функция GetSolidWorksActiveApp
        /// Отвечает за загрузку открытого приложения Solid Works
        /// </summary>
        /// <returns> 
        /// Функция возвращает "object" открытого приложения или "null" в противном случае.
        /// </returns> 
        public object getSolidWorksActiveApp() {
            //Получаем активное(уже запущенное) приложение Solid Works
            object sldApp = null;

            try
            {
                sldApp = Marshal.GetActiveObject("SldWorks.Application");
            }
            catch { }

            return sldApp;
        }

        /// <summary>
        /// Функция OpenSolidWorksApp
        /// Отвечает за загрузку не открытого приложения Solid Works.
        /// </summary>
        /// <returns> 
        /// Функция возвращает "object" загружаемого приложения или "null" в противном случае.
        /// </returns> 
        public object OpenSolidWorksApp()
        {
            //Проверяем есть ли открытое приложение Solid Works иначе загружаем его.
            object sldApp = getSolidWorksActiveApp() ?? Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application"));
            
            return sldApp;
        }

        /// <summary>
        /// Функция ShowSolidWorksWindow
        /// Отвечает за отображение приложения Solid Works.
        /// </summary>
        /// <param name="swApp">Активное приложение Solid Works.</param>
        public void ShowSolidWorksWindow(object swApp)
        {
            (swApp as SldWorks).Visible = true;
        }

        /// <summary>
        /// Функция ShowSolidWorksWindow
        /// Отвечает за скрытие приложения Solid Works.
        /// </summary>
        /// <param name="swApp">Активное приложение Solid Works.</param>
        public void HideSolidWorksWindow(object swApp)
        {
            (swApp as SldWorks).Visible = false;
        }

        private String GetSimulationAppId(SldWorks swApp)
        {
            // Determine host SOLIDWORKS major version
            int swVersion = Convert.ToInt32(swApp.RevisionNumber().Substring(0, 2));

            // Calculate the version-specific ProgID of the Simulation add-in that is compatible with this version of SOLIDWORKS
            int cwVersion = swVersion - 15;

            String cwProgID = String.Format("SldWorks.Simulation.{0}", cwVersion);

            return cwProgID;
        }
        
        public dynamic GetSimulation(object swApp)
        {
            SldWorks sldWorks = swApp as SldWorks;

            string cwProgID = GetSimulationAppId(sldWorks);

            // Get the SOLIDWORKS Simulation object 
            dynamic COSMOSObject = sldWorks.GetAddInObject(cwProgID);

            //return COSMOSObject.CosmosWorks;
            return COSMOSObject == null ? null : COSMOSObject.CosmosWorks;
        }
        
        private bool SimulationIsOpen(SldWorks swApp)
        {

            // Get the SOLIDWORKS Simulation object 
            dynamic COSMOSObject = GetSimulation(swApp);

            return COSMOSObject != null;
        }

        public void LoadSimulation(object swApp)
        {
            SldWorks sldWorks = swApp as SldWorks;

            if (!SimulationIsOpen(sldWorks))
            {
                string path_to_cosworks_dll = sldWorks.GetExecutablePath() + @"\Simulation\cosworks.dll";
                int errors = sldWorks.LoadAddIn(path_to_cosworks_dll);
            }


        }

    }
}