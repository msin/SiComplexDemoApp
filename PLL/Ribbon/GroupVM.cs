using System.Collections.ObjectModel;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class GroupVM : IGroup
    {
        public virtual string Name { get; set; }

        public virtual ObservableCollection<IItem> Items { get; set; }

        public GroupVM()
        {
            Items = new ObservableCollection<IItem>();
        }
    }
}
