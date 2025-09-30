using Tyuiu.IvanovIA.Sprint1.Task3.V12.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 4;
            double ress = 6;
            var res = ds.TriangleArea(x, y); 
            Assert.AreEqual(ress, res);
        }
    }
}
