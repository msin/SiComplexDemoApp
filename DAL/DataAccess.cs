using System.Collections.Generic;
using IocApp.CIL;

namespace IocApp.DAL
{
    public class DataAccess : IDataAccess
    {
        public AbstractEntity Get<T>(int id) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetList<T>(string where) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public int Insert<T>(T item) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<int> InsertMany<T>(IEnumerable<T> items) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public bool Delete<T>(int id) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteMany<T>(int[] ids) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public bool Update<T>(T item) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateMany<T>(IEnumerable<T> items) where T : AbstractEntity
        {
            throw new System.NotImplementedException();
        }
    }
}
