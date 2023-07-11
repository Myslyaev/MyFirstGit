using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17
{
    public static class Bank
    {
        public static void GetBankOffers()
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во ваших банковких продуктов");
            int bankProduct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму ваших средств");
            int moneyAmount = Convert.ToInt32(Console.ReadLine());
            if (age >= 60 || moneyAmount >= 1000000)
            {
                Console.WriteLine($"{name}, вам доступны акционные предложения.");
            }
            else if (moneyAmount >= 400000 && bankProduct >= 3)
            {
                Console.WriteLine($"{name}, вам доступны акционные предложения.");
            }
            else
            {
                Console.WriteLine($"{name}, вам не доступны акционные предложения.");
            }
        }
        public static void CalculateDepositPercents()
        {
            Console.WriteLine("Укажите размер первоначального вклада");
            int dep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите срок вклада в годах");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите процент вклада");
            int perc = Convert.ToInt32(Console.ReadLine());
            int profit = 0;
            int total = 0;
            for (int i = 1; i <= year; i++)
            {
                if (i == 1)
                {
                    profit = dep / 100 * perc;
                    total = dep + profit;
                    continue;
                }
                dep = dep + profit;
                profit = dep / 100 * perc;
                total = dep + profit;
            }
            Console.WriteLine("Ваш вклад с процентами составляет: " + total + " руб.");
        }
        public static int GetBanknotesQuantity(int thousand = 1000, int fiveHundred = 500, int oneHundred = 100)
        {
            Console.WriteLine("Укажите сумму, которую хотите снять");
            int money = Convert.ToInt32(Console.ReadLine());
            int banknoteTh = money / thousand;
            int tmpTh = money - (thousand * banknoteTh);
            int banknoteFh = tmpTh / fiveHundred;
            int tmpFh = tmpTh - (fiveHundred * banknoteFh);
            int banknoteOh = tmpFh / oneHundred;
            int banknotesQuantity = banknoteTh + banknoteFh + banknoteOh;
            return banknotesQuantity;
        }
    }
}

