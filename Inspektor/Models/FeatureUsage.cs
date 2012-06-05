using System;

namespace Inspektor.Models
{
    public class FeatureUsage
    {
        public string ApplicationName { get; set; }

        public string FeatureName { get; set; }

        public string Notes { get; set; }

        public string UsedBy { get; set; }

        public DateTime UsedDate { get; set; }
    }
}