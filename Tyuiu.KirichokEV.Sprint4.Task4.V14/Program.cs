using Tyuiu.KirichokEV.Sprint4.Task4.V14.Lib;

namespace Tyuiu.KirichokEV.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                         *");
            Console.WriteLine("* Тема: Двумерные массивы                                                           *");
            Console.WriteLine("* Задание #4                                                                        *");
            Console.WriteLine("* Вариант #14                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный значениями с     *");
            Console.WriteLine("* класиватуры в диапазоне от 1 до 8. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* 1, 3, 7, 7, 6                                                                     *");
            Console.WriteLine("* 4, 2, 6, 3, 3                                                                     *");
            Console.WriteLine("* 4, 5, 1, 4, 6                                                                     *");
            Console.WriteLine("* 7, 5, 2, 7, 7                                                                     *");
            Console.WriteLine("* 2, 4, 4, 4, 7                                                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("*************************************************************************************");
            
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите {i}, {j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            int[,] res = ds.Calculate(mtrx);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
