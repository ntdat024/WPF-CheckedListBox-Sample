using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using OPENSOURCE.WPFCheckedListBox;
using System.Collections.Generic;

namespace OPENSOURCE
{
    [Transaction(TransactionMode.Manual)]
    public class TestCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var options = new List<CheckedListBoxItem>
            {
                new CheckedListBoxItem("abc1", false),
                new CheckedListBoxItem("abc2", false),
                new CheckedListBoxItem("abc3", false),
                new CheckedListBoxItem("abc4", false),
                new CheckedListBoxItem("abc5", false),
                new CheckedListBoxItem("abc6", false),
            };

            var window = new WPFCheckedListBoxView(options);
            window.ShowDialog();

            return Result.Succeeded;
        }
    }
}
