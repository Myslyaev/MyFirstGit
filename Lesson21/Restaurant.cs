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
            int quantity = Convert.ToInt32(Console.ReadLine());
            return quantity;
        }
        public static int[] ReadOrdersQuantity(int[] ordersQuantity)
        {
            int i = 0;
            Console.WriteLine("Введите количество заказов блюд по одному, в конце напишите слово: конец");
            string number;
            while ((number = Console.ReadLine()) != "конец")
            {
                ordersQuantity[i++] = Convert.ToInt32(number);
            }
            return ordersQuantity;
        }
        public static int[] SortOrdersQuantity(int[] ordersQuantity)
        {
            for (int i = 0; i < ordersQuantity.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j < ordersQuantity.Length; j++)
                {
                    if (ordersQuantity[minIndex] < ordersQuantity[j])
                    {
                        minIndex = j;
                    }
                }
                int tmp = ordersQuantity[minIndex];
                ordersQuantity[minIndex] = ordersQuantity[i];
                ordersQuantity[i] = tmp;
            }
            return ordersQuantity;
        }
        public static void WriteOrdersQuantity(int[] ordersQuantity)
        {
            for (int i = 0; i < ordersQuantity.Length; i++)
            {
                Console.Write($"{ordersQuantity[i]} ");
            }
        }
    }
}
