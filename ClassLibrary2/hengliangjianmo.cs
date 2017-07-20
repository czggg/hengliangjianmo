using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB.Architecture;
using System.IO;

namespace ClassLibrary2
{
    [Transaction(TransactionMode.Manual)]
    public class hengliangjianmo : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication rvtUiApp = commandData.Application;
            Application rvtApp = rvtUiApp.Application;
            UIDocument rvtUiDoc = rvtUiApp.ActiveUIDocument;
            Document rvtDoc = rvtUiDoc.Document;







            return Result.Succeeded;
        }
    }
}
