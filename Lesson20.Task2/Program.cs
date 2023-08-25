GetAndWritePrice();

static void GetAndWritePrice()
{
    Console.WriteLine("Введите количество товаров");
    int productsNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите закупочную цену товара по одному, в конце напишите слово: конец");

    double[] prices = new double[productsNumber];
    int i = 0;
    string price;
    while ((price = Console.ReadLine()) != "конец")
    {
        prices[i++] = Convert.ToInt32(price);
    }

    for (i = 0; i < prices.Length; i++)
    {
        Console.WriteLine($"Цена с наценкой: {prices[i] + prices[i] / 100 * 18}");
    }
}