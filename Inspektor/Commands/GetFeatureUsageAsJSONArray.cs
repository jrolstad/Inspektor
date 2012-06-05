using System.Collections.Generic;
using System.Linq;
using Inspektor.Entities;
using Inspektor.Models;

namespace Inspektor.Commands
{
    /// <summary>
    /// Obtains feature usage data as a JSON array
    /// </summary>
    public class GetFeatureUsageAsJSONArray : ICommand<FeatureUsageRequest, IEnumerable<string[]>>
    {
        private readonly IRepository _repository;

        /// <summary>
        /// Constructor with dependencies
        /// </summary>
        /// <param name="repository"></param>
        public GetFeatureUsageAsJSONArray(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<string[]> Execute( FeatureUsageRequest parameters )
        {
            var usages = _repository.Find<FeatureUsage>();
            var headerRow = new[] {"Application", "Feature", "Usage", "UsedAt", "UsedBy"};

            var dataRows = usages.Select(u=>new[]{u.Feature.ApplicationName,u.Feature.FeatureName,"1",u.UsedDate.ToString(),u.UsedBy.Replace(@"\",@"\\")});

            var jsonArray = new List<string[]> {headerRow};
            jsonArray.AddRange(dataRows);

            return jsonArray;
        }
    }
}