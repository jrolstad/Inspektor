using System;

namespace Inspektor.Data.Models
{
    public class FeatureUsage
    {
        public int FeatureUsageId { get; set; }

        public Feature Feature { get; set; }

        public string UsedBy { get; set; }

        public DateTime UsedAt { get; set; }
    }
}