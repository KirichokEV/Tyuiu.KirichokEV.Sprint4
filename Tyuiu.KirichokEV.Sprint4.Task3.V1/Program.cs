using System.Data.Common;
using Tyuiu.KirichokEV.Sprint4.Task3.V1.Lib;

namespace Tyuiu.KirichokEV.Sprint4.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] mtrx = new int[5, 5] { { 3, 4, 3, 4, 1 },
                                          { 8, 1, 6, 6, 9 },
                                          { 9, 8, 5, 1, 3 },
                                          { 1, 8, 7, 1, 2 },
                                          { 9, 9, 7, 5, 6 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Двумерные массивы                                                          *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #1                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими     *");
            Console.WriteLine("* значениями в диапазоне от 1 до 9. Найдите сумму элементов в последнем столбце     *");
            Console.WriteLine("* 3, 4, 3, 4, 1                                                                     *");
            Console.WriteLine("* 8, 1, 6, 6, 9                                                                     *");
            Console.WriteLine("* 9, 8, 5, 1, 3                                                                     *");
            Console.WriteLine("* 1, 8, 7, 1, 2                                                                     *");
            Console.WriteLine("* 9, 9, 7, 5, 6                                                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма элементов в последнем столбце массива = " + res);
            Console.ReadKey();
        }
    }
}
