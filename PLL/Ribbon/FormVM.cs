using System;
using System.Windows;
using DevExpress.Xpf.Docking;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class FormVM : IForm
    {
        string IMVVMDockingProperties.TargetName
        {
            get { return "DocumentsGroup"; }
            set { throw new NotImplementedException(); }
        }

        public virtual string Caption { get; set; }
        
        public virtual Point Location { get; set; }
        
        public virtual Size Size { get; set; }
        
        public virtual string Icon { get; set; }
    }
}
