namespace Inspektor
{
    /// <summary>
    /// Command interface
    /// </summary>
    /// <typeparam name="TIn">Parameter type to input</typeparam>
    /// <typeparam name="TOut">Type of return</typeparam>
    public interface ICommand<in TIn, out TOut>
    {
        /// <summary>
        /// Executes the given command
        /// </summary>
        /// <param name="parameters">Parameters for the command</param>
        /// <returns></returns>
        TOut Execute(TIn parameters);
    }
}