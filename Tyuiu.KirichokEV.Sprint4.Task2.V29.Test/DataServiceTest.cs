using Tyuiu.KirichokEV.Sprint4.Task2.V29.Lib;

namespace Tyuiu.KirichokEV.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCal()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 5, 6, 3, 7, 3, 2, 2, 6, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 1152;
            Assert.AreEqual(wait, res);
        }
    }
}