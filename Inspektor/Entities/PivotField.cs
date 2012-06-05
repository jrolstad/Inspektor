namespace Inspektor.Entities
{
    public class PivotField
    {
        public string name { get; set; }

        public string type { get; set; }

        public bool filterable { get; set; }

        public bool labelable { get; set; }

        public bool columnLabelable { get; set; }

        public string summarizable { get; set; }
    }
}