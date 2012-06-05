using System;
using System.Collections.Generic;
using System.Linq;
using FizzWare.NBuilder;
using Inspector.Web.Infrastructure;
using Inspector.Web.Models;
using Inspektor.Entities;
using NUnit.Framework;
using Ninject;

namespace Inspektor.Web.Test.Mappers
{
    [TestFixture]
    public class When_mapping_a_feature_usage_request
    {

        private StandardKernel _kernel;
        private FeatureUsageWebRequest _webRequest;
        private FeatureUsageRequest _result;


        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _kernel = new StandardKernel();
            ApplicationConfiguration.Configure(_kernel);

            _webRequest = Builder<FeatureUsageWebRequest>.CreateNew().Build();

            var mapper = _kernel.Get<IMapper<FeatureUsageWebRequest, FeatureUsageRequest>>();

            _result = mapper.Map(_webRequest);
        }


        [Test]
        public void Then_the_application_is_mapped()
        {
            // Assert
            Assert.That(_result.Application,Is.EqualTo(_webRequest.Application));
        }

        [Test]
        public void Then_the_feature_is_mapped()
        {
            // Assert
            Assert.That(_result.Feature, Is.EqualTo(_webRequest.Feature));
        }

        [Test]
        public void Then_the_used_by_is_mapped()
        {
            // Assert
            Assert.That(_result.UsedBy, Is.EqualTo(_webRequest.UsedBy));
        }

    }
}