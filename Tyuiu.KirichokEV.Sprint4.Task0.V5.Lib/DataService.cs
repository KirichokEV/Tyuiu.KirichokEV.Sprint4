using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KirichokEV.Sprint4.Task0.V5.Lib
{
    public class DataService : ISprint4Task0V5
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int esum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    esum += array[i];
                }
            }
            return esum;
        }
    }
}
