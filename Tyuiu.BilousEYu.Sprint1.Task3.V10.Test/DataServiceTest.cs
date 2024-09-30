using Tyuiu.BilousEYu.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BilousEYu.Sprint1.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 23.6;
            Assert.AreEqual(23.6, number);


        }
    }
}