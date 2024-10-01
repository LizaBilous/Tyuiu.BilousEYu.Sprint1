using Tyuiu.BilousEYu.Sprint1.Task4.V6.Lib;
namespace Tyuiu.BilousEYu.Sprint1.Task4.V6Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VallidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}