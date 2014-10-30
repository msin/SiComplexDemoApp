using System.Collections.ObjectModel;

namespace IocApp.CIL.Ribbon
{
    public interface IGroup
    {
        string Name { get; set; }

        ObservableCollection<IItem> Items { get; set; }
    }
}
