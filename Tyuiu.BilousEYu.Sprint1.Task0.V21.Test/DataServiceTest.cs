using Tyuiu.BilousEYu.Sprint1.Task0.V21.Lib;
namespace Tyuiu.BilousEYu.Sprint1.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(17, res);

        }
    }
}
