//using JA.Util.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace JA.Tests
{
    [TestClass]
    public class SNS_UnitTests
    {
        [TestMethod]
        public void Test1()
        {
            var mock = new Mock<IGetDataRepository>();
           // mock.Setup(p => p.GetNameById(1)).Returns("Jignesh");
            //HomeController home = new HomeController(mock.Object);
           // string result = home.GetNameById(1);
            //Assert.AreEqual("Jignesh", result);
        }
    }
}
