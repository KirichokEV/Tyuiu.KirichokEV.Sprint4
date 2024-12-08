using Tyuiu.KirichokEV.Sprint4.Task4.V14.Lib;

namespace Tyuiu.KirichokEV.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCal()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 1, 3, 7, 7, 6 },
                                          { 4, 2, 6, 3, 3 },
                                          { 4, 5, 1, 4, 6 },
                                          { 7, 5, 2, 7, 7 },
                                          { 2, 4, 4, 4, 7 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = { { 1, 3, 7, 7, 0 },
                            { 0, 0, 0, 3, 3 },
                            { 0, 5, 1, 0, 0 },
                            { 7, 5, 0, 7, 7 },
                            { 0, 0, 0, 0, 7 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}