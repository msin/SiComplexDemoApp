using System.Collections.ObjectModel;

namespace IocApp.CIL.Ribbon
{
    public interface IPage
    {
        string Name { get; set; }

        ObservableCollection<IGroup> Groups { get; set; }
    }
}
