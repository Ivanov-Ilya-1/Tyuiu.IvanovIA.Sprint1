using Tyuiu.IvanovIA.Sprint1.Task7.V3.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = 1;
            double wait = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
