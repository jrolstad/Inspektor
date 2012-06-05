namespace Inspektor.Entities
{
    public class FeatureUsageRequest
    {
        public string Application { get; set; }

        public string Feature { get; set; }

        public string UsedBy { get; set; }
    }
}