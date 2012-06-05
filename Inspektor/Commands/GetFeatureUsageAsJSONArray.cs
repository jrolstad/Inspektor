using System.Collections.Generic;
using System.Linq;
using Inspektor.Entities;
using Inspektor.Extensions;
using Inspektor.Models;

namespace Inspektor.Commands
{
    /// <summary>
    /// Obtains feature usage data as a JSON array
    /// </summary>
    public class GetFeatureUsageAsJSONArray : ICommand<FeatureUsageRequest, IEnumerable<string[]>>
    {
        private readonly IRepository<FeatureUsage> _repository;

        /// <summary>
        /// Constructor with dependencies
        /// </summary>
        /// <param name="repository"></param>
        public GetFeatureUsageAsJSONArray(IRepository<FeatureUsage> repository)
        {
            _repository = repository;
        }

        public IEnumerable<string[]> Execute( FeatureUsageRequest parameters )
        {
            var usages = _repository.Find();
            var headerRow = new[] {"Application", "Feature", "Usage", "UsedAt", "UsedBy"};

            var dataRows = usages.Select(u=>new[]
                                                {
                                                    u.ApplicationName,
                                                    u.FeatureName,
                                                    "1",
                                                    u.UsedDate.ToString(),
                                                    u.UsedBy.WithCleanUserName()
                                                });

            var jsonArray = new List<string[]> {headerRow};
            jsonArray.AddRange(dataRows);

            return jsonArray;
        }
    }
}