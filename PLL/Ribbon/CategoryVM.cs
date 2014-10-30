using System.Collections.ObjectModel;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class CategoryVM : ICategory
    {
        public virtual string Name { get; set; }

        public virtual ObservableCollection<IPage> Pages { get; set; }

        public CategoryVM()
        {
            Pages = new ObservableCollection<IPage>();
        }
    }
}
