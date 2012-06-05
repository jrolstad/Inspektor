using System.Linq;

namespace Inspektor.Data
{
    /// <summary>
    /// Repository Interface for data access
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Queries the data source
        /// </summary>
        /// <typeparam name="T">Type to search for</typeparam>
        /// <returns></returns>
        IQueryable<T> Find<T>();

        /// <summary>
        /// Obtains an item with the given key
        /// </summary>
        /// <typeparam name="T">Item type to get</typeparam>
        /// <typeparam name="I">Type of the key to get</typeparam>
        /// <param name="key">Key to find an item for</param>
        /// <returns></returns>
        T Get<T, I>(I key);

        /// <summary>
        /// Performs an upsert on a single item
        /// </summary>
        /// <typeparam name="T">Type of the item to save</typeparam>
        /// <param name="toSave">Item to be saved</param>
        void Save<T>(T toSave);

        /// <summary>
        /// Deletes a single item
        /// </summary>
        /// <typeparam name="T">Item type</typeparam>
        /// <param name="toDelete">Item to delete</param>
        void Delete<T>(T toDelete);

        /// <summary>
        /// Deletes an item by its given key
        /// </summary>
        /// <typeparam name="I">Type of the key</typeparam>
        /// <param name="key">Key to delete</param>
        void DeleteById<I>(I key);
    }
}