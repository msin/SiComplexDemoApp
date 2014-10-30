using DevExpress.Mvvm.POCO;
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

            IoC.Instance.Register<IItem>(ViewModelSource.Create<ItemVM>);

            IoC.Instance.Register<IGroup>(ViewModelSource.Create<GroupVM>);

            IoC.Instance.Register<IPage>(ViewModelSource.Create<PageVM>);

            IoC.Instance.Register<ICategory>(ViewModelSource.Create<CategoryVM>);

            IoC.Instance.RegisterSingle<IRibbon>(ViewModelSource.Create<RibbonVM>);

            IoC.Instance.Register<IDesk>(ViewModelSource.Create<DeskVM>);

            #endregion

            IoC.Instance.RegisterSingle<IMain>(ViewModelSource.Create<MainVM>);
        }
    }
}
