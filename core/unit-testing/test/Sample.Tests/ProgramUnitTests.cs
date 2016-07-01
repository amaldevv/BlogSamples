using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Application;
namespace Sample.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void SumSuccess()
        {
            var res = (new Utils()).Sum(1,6);
            Assert.AreEqual(7, res);

        }
    }
}