using System;

namespace Inspektor.Models
{
    public class FeatureUsage
    {
        public int FeatureUsageId { get; set; }

        public Feature Feature { get; set; }

        public string Notes { get; set; }

        public string UsedBy { get; set; }

        public DateTime UsedDate { get; set; }
    }
}