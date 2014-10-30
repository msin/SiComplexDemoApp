using DevExpress.Mvvm;
using IocApp.CIL;

namespace IocApp.PLL
{
    public class MainVM : IMain
    {
        public virtual IMessageBoxService MessageBoxService { get { return null; } }

        public void Loaded()
        {
            Messenger.Default.Send(new Message(MessageType.Loaded));
        }
    }
}
