using DevExpress.Xpf.Core;
using DevExpress.Xpf.Ribbon;
using IocApp.CIL;
using IocApp.UIL.Views;

namespace IocApp.UIL
{
    public class _Package : IPackage
    {
        public void RegisterServices()
        {
            IoC.Instance.RegisterSingle<DXRibbonWindow, MainWindow>();
        }
    }
}
