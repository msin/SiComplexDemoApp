using DevExpress.Mvvm;

namespace IocApp.CIL
{
    public interface IMain
    {
        IMessageBoxService MessageBoxService { get; }

        void Loaded();
    }
}
