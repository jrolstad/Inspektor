using System;

namespace Inspector.Web.Models
{
    public class FeatureUsageRequest
    {
        public string Application { get; set; }

        public string Feature { get; set; }

        public string UsedBy { get; set; }

        public string UsedAt { get; set; }
    }
}