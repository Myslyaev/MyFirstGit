using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22
{
    public static class Cinema
    {
        public static int GetCountDays()
        {
            Console.Write("Введите количество дней: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int GetCountFilms()
        {
            Console.Write("Введите количество фильмов: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int[,] InputFilmsPopularityArr(int countDays, int countFilms)
        {
            int[,] filmsPopularityArr = new int[countDays, countFilms];
            Console.WriteLine();
            for (int i = 0; i < countDays; i++)
            {
                for (int j = 0; j < countFilms; j++)
                {
                    Console.Write("Введите количество просмотров: ");
                    filmsPopularityArr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return filmsPopularityArr;
        }

        public static void ShowFilmsPopularityArr(int[,] filmsPopularityArr)
        {
            Console.WriteLine("График просмотра фильмов:");
            for (int i = 0; i < filmsPopularityArr.GetLength(0); i++)
            {
                for (int j = 0; j < filmsPopularityArr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", filmsPopularityArr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void GetFilmsSum(int[,] filmsPopularityArr)
        {
            int[] filmsSumArr = new int[filmsPopularityArr.GetLength(1)];
            int sum = 0;
            for (int j = 0; j < filmsPopularityArr.GetLength(1); j++)
            {
                for (int i = 0; i < filmsPopularityArr.GetLength(0); i++)
                {
                    sum += filmsPopularityArr[i, j];
                }
                filmsSumArr[j] = sum;
                sum = 0;

                Console.WriteLine($"Сумма просмотров {j + 1} фильма: {filmsSumArr[j]}");
            }
        }
    }
}
