using System.Linq;

namespace Inspektor.Data.NH
{
    public class NHibernateRepository:IRepository
    {
        public IQueryable<T> Find<T>()
        {
            throw new System.NotImplementedException();
        }

        public T Get<T, I>(I key)
        {
            throw new System.NotImplementedException();
        }

        public void Save<T>(T toSave)
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T toDelete)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteById<I>(I key)
        {
            throw new System.NotImplementedException();
        }
    }
}