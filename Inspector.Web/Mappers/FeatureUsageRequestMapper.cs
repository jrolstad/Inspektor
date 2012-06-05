using Inspector.Web.Models;
using Inspektor;
using Inspektor.Entities;

namespace Inspector.Web.Mappers
{
    public class FeatureUsageRequestMapper:IMapper<FeatureUsageWebRequest,FeatureUsageRequest>
    {
        public FeatureUsageRequest Map( FeatureUsageWebRequest source )
        {
            return new FeatureUsageRequest
                       {
                           Application = source.Application,
                           Feature = source.Feature,
                           UsedBy = source.UsedBy
                       };
        }
    }
}