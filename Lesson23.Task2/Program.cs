GetAndWritePriceList();

static void GetAndWritePriceList()
{
    Console.WriteLine("Введите закупочную цену товара по одному, в конце напишите слово: конец");

    List<double> pricesList = new List<double>();
    string price;
    while ((price = Console.ReadLine()) != "конец")
    {
        pricesList.Add(Convert.ToInt32(price));
    }

    foreach (double i in pricesList)
    {
        Console.WriteLine($"Цена с наценкой: {i + i / 100 * 18}");
    }
}