using Tyuiu.KirichokEV.Sprint4.Task0.V5.Lib;

namespace Tyuiu.KirichokEV.Sprint4.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Одномерные массивы                                                          *");
            Console.WriteLine("* Задание #0                                                                        *");
            Console.WriteLine("* Вариант #5                                                                        *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный статическими      *");
            Console.WriteLine("* значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива        *");
            Console.WriteLine("* {8, 9, 4, 1, 2, 3, 4, 5, 6, 7 }                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            int res = ds.GetSumEvenArrEl(numsArray);
            for (int i = 0; i <= numsArray.Length - 1; i++)
                Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

