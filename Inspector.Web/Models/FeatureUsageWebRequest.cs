using System;

namespace Inspector.Web.Models
{
    public class FeatureUsageWebRequest
    {
        public string Application { get; set; }

        public string Feature { get; set; }

        public string UsedBy { get; set; }
    }
}