using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.UI;
using DevExpress.Xpf.Core;
using IocApp.CIL;
using IocApp.CIL.Ribbon;
using IocApp.PLL.Ribbon;

namespace IocApp.PLL
{
    public class _Package : IPackage
    {
        public void RegisterServices()
        {
            #region | Ribbon ViewModels |

            //IoC.Instance.Register<IItem>(ViewModelSource.Create<ItemVM>);
            IoC.Instance.Register(typeof(IItem), ViewModelSource.GetPOCOType(typeof(ItemVM)));

            IoC.Instance.Register<IGroup>(ViewModelSource.Create<GroupVM>);

            IoC.Instance.Register<IPage>(ViewModelSource.Create<PageVM>);

            IoC.Instance.Register<ICategory>(ViewModelSource.Create<CategoryVM>);

            IoC.Instance.RegisterSingle<IRibbon>(ViewModelSource.Create<RibbonVM>);

            IoC.Instance.Register<IDesk>(ViewModelSource.Create<DeskVM>);

            IoC.Instance.Register<IForm>(ViewModelSource.Create<FormVM>);

            #endregion

            IoC.Instance.Register(typeof(IMain), ViewModelSource.GetPOCOType(typeof(MainVM)));

            IoC.Instance.RegisterSingle<IMessageBoxService, DXMessageBoxService>();

            IoC.Instance.RegisterSingle<INotificationService>(() =>
                new NotificationService { PredefinedNotificationTemplate = NotificationTemplate.ShortHeaderAndLongText });
        }
    }
}
