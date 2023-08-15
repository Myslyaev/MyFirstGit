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
        public static int GetDepositPercents(int dep, int year, int perc, int total = 0, int profit = 0)
        {
            if (dep < 0 || year < 0 || perc < 0)
            {
                throw new ArgumentException("dep < 0 || year < 0 || perc < 0");
            }
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
            return total;
        }
        public static int GetBanknotesQuantity(int money, int thousand = 1000, int fiveHundred = 500, int oneHundred = 100)
        {
            if (money == 0)
            {
                throw new ArgumentException("money == 0");
            }
            if (money < 0)
            {
                throw new ArgumentException("money < 0");
            }
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
