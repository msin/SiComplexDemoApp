using System.Collections.ObjectModel;

namespace IocApp.CIL.Ribbon
{
    public interface ICategory
    {
        string Name { get; set; }

        ObservableCollection<IPage> Pages { get; set; }
    }
}
