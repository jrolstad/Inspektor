using System.Collections.Generic;
using Inspektor.Entities;

namespace Inspektor.Commands
{
    /// <summary>
    /// Obtains feature usage data as a JSON array
    /// </summary>
    public class GetFeatureUsageAsJSONArray : ICommand<FeatureUsageRequest, IEnumerable<string[]>>
    {
        public IEnumerable<string[]> Execute( FeatureUsageRequest parameters )
        {
            var usageString = new[]
                                  {
                                      new[]{"Application","Feature","Usage","UsedAt","UsedBy"},
                                      new[]{"Magnet","Home","1","2012-05-02","PARAPORT\\User1"},
                                      new[]{"Magnet","Home","1","2012-05-02","PARAPORT\\User2"},
                                      new[]{"Magnet","FX","1","2012-05-01","PARAPORT\\User2"},
                                      new[]{"Verona","Bias","1","2012-05-06","PARAPORT\\User1"},
                                  };

            return usageString;
        }
    }
}