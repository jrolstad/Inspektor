using Inspector.Web.Mappers;
using Inspector.Web.Models;
using Inspektor;
using Inspektor.Entities;
using Ninject.Modules;

namespace Inspector.Web.Infrastructure.DependencyInjection
{
    public class MapperModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper<FeatureUsageWebRequest, FeatureUsageRequest>>().To<FeatureUsageRequestMapper>();
        }
    }
}