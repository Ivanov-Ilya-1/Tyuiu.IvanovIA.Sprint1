using Tyuiu.IvanovIA.Sprint1.Task2.V14.Lib;
namespace Tyuiu.IvanovIA.Sprint1.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExperession()
        {
            DataService ds = new DataService(); 
            int x = 274;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(1, res);
        }


    }
}
