using Lesson17;

Bank.GetBankOffers();
Console.WriteLine();
Console.WriteLine("Укажите размер первоначального вклада");
int dep = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите срок вклада в годах");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите процент вклада");
int perc = Convert.ToInt32(Console.ReadLine());
int depositAmount = Bank.GetDepositPercents(dep, year, perc);
Console.WriteLine($"Ваш вклад с процентами составляет: {depositAmount} руб.");
Console.WriteLine();
Console.WriteLine("Укажите сумму, которую хотите снять");
int money = Convert.ToInt32(Console.ReadLine());
int quantityBaknotes = Bank.GetBanknotesQuantity(money);
Console.WriteLine($"Количество купюр: {quantityBaknotes}.");
