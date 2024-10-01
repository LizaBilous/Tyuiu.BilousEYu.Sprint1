using Tyuiu.BilousEYu.Sprint1.Task6.V1.Lib;
namespace Tyuiu.BilousEYu.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.SymbolCode("1");
            Assert.AreEqual("49", res);
        }
    }
}