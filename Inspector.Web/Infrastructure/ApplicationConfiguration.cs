using Inspector.Web.Infrastructure.DependencyInjection;
using Ninject;
using Ninject.Modules;

namespace Inspector.Web.Infrastructure
{
    public class ApplicationConfiguration
    {
        public static void Configure(IKernel kernel)
        {
            kernel.Load(new INinjectModule[]
                            {
                                new CommandModule(), 
                                new DataModule(), 
                                new MapperModule()
                            });
        }
    }
}