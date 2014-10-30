using System.Collections.ObjectModel;

namespace IocApp.CIL.Ribbon
{
    public interface IRibbon
    {
        ObservableCollection<ICategory> Categories { get; set; }

        ObservableCollection<IDesk> Desks { get; set; }

        int DesktopIndex { get; set; }
    }
}
