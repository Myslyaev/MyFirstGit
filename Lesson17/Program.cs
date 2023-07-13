using Lesson17;

Bank.GetBankOffers();
Console.WriteLine();
Bank.CalculateDepositPercents();
Console.WriteLine();
Console.WriteLine("Укажите сумму, которую хотите снять");
int money = Convert.ToInt32(Console.ReadLine());
int quantityBaknotes = Bank.GetBanknotesQuantity(money);
Console.WriteLine($"Количество купюр: {quantityBaknotes}.");
