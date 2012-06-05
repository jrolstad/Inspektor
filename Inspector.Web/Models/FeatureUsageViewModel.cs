using System;

namespace Inspector.Web.Models
{
    public class FeatureUsageViewModel
    {
        public string ApplicationName { get; set; }

        public string FeatureName { get; set; }

        public string UsedBy { get; set; }

        public DateTime UsedAt { get; set; }
    }
}