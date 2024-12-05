using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KirichokEV.Sprint4.Task3.V1.Lib
{
    public class DataService : ISprint4Task3V1
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                sum += array[i, array.GetLength(1) - 1];
            }
            return sum;
        }
    }
}
