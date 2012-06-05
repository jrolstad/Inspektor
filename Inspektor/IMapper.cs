namespace Inspektor
{
    /// <summary>
    /// Interface for a class that converts from one type to another
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public interface IMapper<in TIn, out TOut>
    {
        /// <summary>
        /// Perform the mapping
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        TOut Map(TIn source);
    }
}