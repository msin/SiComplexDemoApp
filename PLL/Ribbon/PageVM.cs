using System.Collections.ObjectModel;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class PageVM : IPage
    {
        public virtual string Name { get; set; }

        public virtual ObservableCollection<IGroup> Groups { get; set; }

        public PageVM()
        {
            Groups = new ObservableCollection<IGroup>();
        }
    }
}
