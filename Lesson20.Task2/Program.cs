string number;
Console.WriteLine("Введите количество товаров");
int quantity = Convert.ToInt32(Console.ReadLine());
double[] prices = new double[quantity];
int i = 0;
Console.WriteLine("Введите закупочную цену товара по одному, в конце напишите слово: конец");
while ((number = Console.ReadLine()) != "конец")
{
    prices[i++] = Convert.ToInt32(number);
}
for (int n = 0; n < prices.Length; n++)
{
    Console.WriteLine($"Цена с наценкой: {prices[n] + prices[n] / 100 * 18}");
}
