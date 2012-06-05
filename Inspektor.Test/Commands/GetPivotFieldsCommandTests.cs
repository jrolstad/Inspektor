using System.Collections.Generic;
using System.Linq;
using Inspector.Web.Infrastructure;
using Inspektor.Entities;
using NUnit.Framework;
using Ninject;

namespace Inspektor.Test.Commands
{
    [TestFixture]
    public class GetPivotFieldsCommandTests
    {
        private StandardKernel _kernel;

        [TestFixtureSetUp]
        public void BeforeAll()
        {
            _kernel = new StandardKernel();
            ApplicationConfiguration.Configure(_kernel);
        }

        [Test]
        [TestCase( "Application", "string" )]
        [TestCase( "Feature", "string" )]
        [TestCase( "UsedBy", "string" )]
        [TestCase( "UsedAt", "date" )]
        [TestCase( "Usage", "integer" )]
        public void When_getting_fields_then_they_are_obtained_with_the_correct_types( string name, string type )
        {
            // Arrange
            var command = _kernel.Get<ICommand<string, IEnumerable<PivotField>>>();

            // Act
            var result = command.Execute(null);

            // Assert
            var match = result.FirstOrDefault(r => r.name == name);

            Assert.That(match, Is.Not.Null, "Unable to find matching field for {0}", name);
            Assert.That(match.type, Is.EqualTo(type));
        }
    }
}