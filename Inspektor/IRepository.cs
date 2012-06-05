using System;
using System.Linq;

namespace Inspektor
{
    /// <summary>
    /// Repository Interface for data access
    /// </summary>
    public interface IRepository<out T>
    {
        /// <summary>
        /// Queries the data source
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Find();

    }
}