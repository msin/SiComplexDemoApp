using IocApp.CIL;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class DeskVM : IDesk
    {
        public virtual int Index { get; set; }

        public virtual bool Checked { get; set; }

        public virtual string Name { get; set; }

        public virtual string Desc { get; set; }

        protected void OnCheckedChanged()
        {
            if (!Checked) return;

            var ribbon = IoC.Instance.GetInstance<IRibbon>();

            ribbon.DesktopIndex = Index - 1;
        }
    }
}
