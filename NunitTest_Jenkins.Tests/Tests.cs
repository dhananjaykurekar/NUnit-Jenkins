using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitTest_Jenkins.AppServices;

namespace NunitTest_Jenkins.Tests
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void AdditionTest()
        {
            var obj = new NewAppService();

            var result = obj.Add(2, 3);

            Assert.AreEqual(5, result);
        }
    }
}
