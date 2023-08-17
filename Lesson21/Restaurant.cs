using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    public static class Restaurant
    {
        public static int ReadMenuQuantity()
        {
            Console.WriteLine("Введите количество блюд");

            int numberOfDishes = Convert.ToInt32(Console.ReadLine());
            return numberOfDishes;
        }
        public static int[] ReadOrdersQuantity(int[] ordersQuantityArr)
        {
            Console.WriteLine("Введите количество заказов блюд по одному, в конце напишите слово: конец");

            int i = 0;
            string ordersQuantity;
            while ((ordersQuantity = Console.ReadLine()) != "конец")
            {
                ordersQuantityArr[i++] = Convert.ToInt32(ordersQuantity);
            }
            return ordersQuantityArr;
        }
        public static int[] SortOrdersQuantity(int[] ordersQuantityArr)
        {
            for (int i = 0; i < ordersQuantityArr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < ordersQuantityArr.Length; j++)
                {
                    if (ordersQuantityArr[minIndex] < ordersQuantityArr[j])
                    {
                        minIndex = j;
                    }
                }
                int tmp = ordersQuantityArr[minIndex];
                ordersQuantityArr[minIndex] = ordersQuantityArr[i];
                ordersQuantityArr[i] = tmp;
            }
            return ordersQuantityArr;
        }
        public static void WriteOrdersQuantity(int[] ordersQuantityArr)
        {
            for (int i = 0; i < ordersQuantityArr.Length; i++)
            {
                Console.Write($"{ordersQuantityArr[i]} ");
            }
        }
    }
}
