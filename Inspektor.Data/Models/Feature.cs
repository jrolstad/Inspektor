using System.Collections.Generic;

namespace Inspektor.Data.Models
{
    public class Feature
    {
        public int FeatureId { get; set; }

        public string Application { get; set; }

        public string Name { get; set; }

        public IEnumerable<FeatureUsage> Usages { get; set; }
    }
}