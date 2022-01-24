using NUnit.Framework;
using NunitTest_Jenkins.AppServices;

namespace NUnitTest_Jenkins.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var obj = new NewAppService();

            var result = obj.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}