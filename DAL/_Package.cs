using IocApp.CIL;

namespace IocApp.DAL
{
    public class _Package : IPackage
    {
        public void RegisterServices()
        {
            IoC.Instance.RegisterSingle<IDataAccess, DataAccess>();
        }
    }
}
