using Autodesk.Revit.UI;
using Core;
using Nice3point.Revit.Toolkit.External.Handlers;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MyUI
{
    public class MyModelessDialogViewModel
    {
        AsyncEventHandler asyncEventHandler;
        public ICommand Command { get; set; }
        public MyModelessDialogViewModel(AsyncEventHandler asyncEventHandler)
        {
            this.asyncEventHandler = asyncEventHandler;
            Command = new RelayCommand(_ => OnButtonClicked());
            
            // uncommenting the following line leads to an automatic loading of Core.dll
            //BaseClass.TestMethod();
        }

        private async Task OnButtonClicked()
        {
            await this.asyncEventHandler.RaiseAsync(CallTestMethod);
        }

        public void CallTestMethod(UIApplication uiApp)
        {
            int result = BaseClass.TestMethod();
            return;
        }
    }
}
