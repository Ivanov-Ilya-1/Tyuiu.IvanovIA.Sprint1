using Tyuiu.IvanovIA.Sprint1.Task6.V7.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            string line = "Hello World";
            string lin1 = "Hell Worl";
            var res = ds.DeleteLastLetter(line);
            Assert.AreEqual(lin1, res);
        }
    }
}
