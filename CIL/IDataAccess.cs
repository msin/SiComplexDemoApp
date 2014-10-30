using System.Collections.Generic;

namespace IocApp.CIL
{
    public abstract class AbstractEntity
    {
        //
    }   

    public interface IDataAccess
    {
        AbstractEntity Get<T>(int id) where T : AbstractEntity;

        IEnumerable<T> GetList<T>(string where) where T : AbstractEntity;

        int Insert<T>(T item) where T : AbstractEntity;

        IEnumerable<int> InsertMany<T>(IEnumerable<T> items) where T : AbstractEntity;

        bool Delete<T>(int id) where T : AbstractEntity;

        bool DeleteMany<T>(int[] ids) where T : AbstractEntity;

        bool Update<T>(T item) where T : AbstractEntity;

        bool UpdateMany<T>(IEnumerable<T> items) where T : AbstractEntity;
    }
}
