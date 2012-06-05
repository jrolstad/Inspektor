using System;
using System.Collections.Generic;
using System.Linq;
using Inspektor.Extensions;
using NUnit.Framework;

namespace Inspektor.Test.Extensions
{
    [TestFixture]
    public class StringExtensionTests
    {

        [Test]
        [TestCase(@"PARAPORT\JoshR","JoshR")]
        [TestCase(@"FOO\JoshR",@"FOO\\JoshR")]
        [TestCase(@"JoshR","JoshR")]
        [TestCase(@"","")]
        public void When_cleaning_up_a_string_for_a_clean_user_name(string name, string expected)
        {
            // Arrange

            // Act
            var result = name.WithCleanUserName();

            // Assert
            Assert.That(result,Is.EqualTo(expected));
        } 

    }
}