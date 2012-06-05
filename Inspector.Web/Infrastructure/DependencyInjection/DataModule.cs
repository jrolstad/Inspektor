using Inspektor;
using Inspektor.Data;
using Inspektor.Models;
using Ninject.Modules;

namespace Inspector.Web.Infrastructure.DependencyInjection
{
    public class DataModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<FeatureUsage>>().To<DapperFeatureUsageRepository>();
        }
    }
}