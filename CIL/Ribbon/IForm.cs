using System.Windows;
using DevExpress.Xpf.Docking;

namespace IocApp.CIL.Ribbon
{
    public interface IForm : IMVVMDockingProperties
    {
        string Caption { get; set; }

        Point Location { get; set; }

        Size Size { get; set; }

        string Icon { get; set; }
    }
}
