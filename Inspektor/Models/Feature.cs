using System.Collections.Generic;

namespace Inspektor.Data.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }

        public string ApplicationName { get; set; }

        public string FeatureName { get; set; }

        public IEnumerable<FeatureUsage> Usages { get; set; }
    }
}