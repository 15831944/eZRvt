using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace eZRvt
{
    [Transaction(TransactionMode.Manual)]
    public class IECAbout : IExternalCommand
    {
        #region IExternalCommand Members

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string aboutString = "Autodesk Revit ���ٽ�ģ���߼� \r\n" + "by ������";
            TaskDialog.Show("About", aboutString);
            return Result.Succeeded;
        }

        #endregion
    }
}