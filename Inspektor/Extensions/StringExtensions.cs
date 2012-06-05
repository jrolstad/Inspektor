namespace Inspektor.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Cleans up a string to remove user name specific items
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
         public static string WithCleanUserName(this string value)
         {
             return value
                 .Replace(@"PARAPORT\", string.Empty)
                 .Replace(@"\",@"\\");
         }
    }
}