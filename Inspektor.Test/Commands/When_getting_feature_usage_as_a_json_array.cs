using System;
using System.Collections.Generic;
using System.Linq;
using FizzWare.NBuilder;
using Inspector.Web.Infrastructure;
using Inspektor.Entities;
using Inspektor.Extensions;
using Inspektor.Models;
using NUnit.Framework;
using Ninject;
using Rhino.Mocks;

namespace Inspektor.Test.Commands
{
    [TestFixture]
    public class When_getting_feature_usage_as_a_json_array
    {
        private StandardKernel _kernel;
        private string[][] _result   ;
        private EnumerableQuery<FeatureUsage> _usagesInRepository;


        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _kernel = new StandardKernel();
            ApplicationConfiguration.Configure(_kernel);

            _usagesInRepository = new EnumerableQuery<FeatureUsage>(Builder<FeatureUsage>
                                                                        .CreateListOfSize(10)
                                                                        .Build());
            var repository = MockRepository.GenerateStub<IRepository<FeatureUsage>>();
            repository.Stub(r => r.Find()).Return(new EnumerableQuery<FeatureUsage>(_usagesInRepository));

            _kernel.Rebind<IRepository<FeatureUsage>>().ToConstant(repository);

            var request = Builder<FeatureUsageRequest>.CreateNew().Build();
            var command = _kernel.Get<ICommand<FeatureUsageRequest, IEnumerable<string[]>>>();

            _result = command.Execute(request).ToArray();
        }

        [Test]
        public void Then_the_first_item_is_the_header_row()
        {
            // Assert
            Assert.That(_result[0], Is.EquivalentTo(new[] { "Application", "Feature","Notes", "Usage", "UsedBy", "Year", "Month", "Day", "Hour", "Minute" }));
        }

        [Test]
        public void Then_each_usage_is_converted()
        {
            // Assert
            Assert.That(_result.Count(),Is.EqualTo(_usagesInRepository.Count() + 1),"All usages should be reported, plus the header row");
        }


        [Test]
        public void Then_each_usage_is_converted_into_an_array()
        {
            // Assert
            foreach (var featureUsage in _usagesInRepository)
            {
                var match = _result.Where(r => IsMatch(featureUsage, r));
                Assert.That(match.Count(), Is.EqualTo(1), "There should only be 1 match for the given feature");
            }
        }

        private static bool IsMatch( FeatureUsage featureUsage, string[] r )
        {
            return r[0] == featureUsage.ApplicationName
                   && r[1] == featureUsage.FeatureName
                   && r[2] == featureUsage.Notes
                   && r[3] == "1"
                   && r[4] == featureUsage.UsedBy.WithCleanUserName()
                   && r[5] == featureUsage.UsedDate.Year.ToString()
                   && r[6] == featureUsage.UsedDate.Month.ToString()
                   && r[7] == featureUsage.UsedDate.Day.ToString()
                   && r[8] == featureUsage.UsedDate.Hour.ToString()
                   && r[9] == featureUsage.UsedDate.Minute.ToString();
        }
    }
}