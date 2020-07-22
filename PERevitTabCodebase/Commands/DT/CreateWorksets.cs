﻿#region autodesk libraries
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
#endregion

#region system libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace PERevitTab.Commands.DT
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    class CreateWorksets : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            try
            {
                Document doc = commandData.Application.ActiveUIDocument.Document;
                IList<Workset> allWorksets = new FilteredWorksetCollector(doc).OfKind(WorksetKind.UserWorkset).ToList();
                if (allWorksets.Count > 1)
                {
                    Forms.WorksetCreator wf = new Forms.WorksetCreator(doc);
                    wf.ShowDialog();
                    wf.Close();
                    return Result.Succeeded;
                }
                else
                {
                    MessageBox.Show("Worksharing is not enabled in the document. Enable collaboration and try again.", "Error:");
                    return Result.Failed;
                }
            }
            catch (Exception err)
            {
                TaskDialog.Show("Error", err.ToString());
                return Result.Failed;
            }
        }
    }
}
