using System.Collections.Generic;
using Inspector.Web.Models;
using Inspektor;
using Inspektor.Commands;
using Inspektor.Entities;
using Ninject.Modules;

namespace Inspector.Web.Infrastructure.DependencyInjection
{
    public class CommandModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICommand<string, IEnumerable<PivotField>>>().To<GetPivotFieldsCommand>();
            Bind<ICommand<FeatureUsageRequest, IEnumerable<string[]>>>().To<GetFeatureUsageAsJSONArray>();
        }
    }
}