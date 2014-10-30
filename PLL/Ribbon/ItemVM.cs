using System.Windows;
using DevExpress.Mvvm;
using IocApp.CIL;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class ItemVM : IItem
    {
        public virtual string Name { get; set; }

        public virtual string Hint { get; set; }

        public void Click()
        {
            var main = IoC.Instance.GetInstance<IMain>();

            main.MessageBoxService.Show(Name + " is clicked", "MessageBoxService", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
