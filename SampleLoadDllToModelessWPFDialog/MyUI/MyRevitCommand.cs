using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using Nice3point.Revit.Toolkit.External.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUI
{
    [Transaction(TransactionMode.Manual)]
    public class MyRevitCommand : ExternalCommand
    {
        public override void Execute()
        {
            AsyncEventHandler asyncEventHandler = new AsyncEventHandler();

            MyModelessDialogViewModel viewModel = new MyModelessDialogViewModel(asyncEventHandler);
            MyModelessDialog dialog = new MyModelessDialog
            {
                DataContext = viewModel
            };

            dialog.Show();
        }
    }
}
