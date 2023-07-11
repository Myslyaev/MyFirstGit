using Lesson17;

Bank.GetBankOffers();
Console.WriteLine();
Bank.CalculateDepositPercents();
Console.WriteLine();
int quantityBaknotes = Bank.GetBanknotesQuantity();
Console.WriteLine($"Количество купюр: {quantityBaknotes}.");
