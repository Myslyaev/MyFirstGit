namespace Lesson29
{
    public class BaseProduct
    {
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public int Memory { get; set; }
        public int Display { get; set; }
        public int Price { get; set; }
        public BaseProduct(string title, string manufacturer, int memory, int display, int price)
        {
            Title = title;
            Manufacturer = manufacturer;
            Memory = memory;
            Display = display;
            Price = price;
        }
        public void WriteShortInfo()
        {
            Console.WriteLine($"{Title} {Manufacturer}: {Price} руб.");
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseProduct product &&
                   Title == product.Title;
        }

        public virtual void ShowOptPrice()
        {
            Console.WriteLine("Введите количество товара");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity >= 5)
            {
                Price = Price - Price / 100 * 7;
            }
            Console.WriteLine($"Цена: {Price} руб.");
        }
    }
}
