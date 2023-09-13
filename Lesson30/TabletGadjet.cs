namespace Lesson30
{
    public class TabletGadjet : AbstractGadjet
    {
        public int Camera { get; set; }
        public string Stylus { get; set; }
        public TabletGadjet(string title, string manufacturer, int memory, int display, int price, int camera, string stylus)
        {
            Title = title;
            Manufacturer = manufacturer;
            Memory = memory;
            Display = display;
            Price = price;
            Camera = camera;
            Stylus = stylus;
        }

        public override void ShowOptPrice()
        {
            Console.WriteLine("Введите количество товара");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity >= 5)
            {
                Price = Price - Price / 100 * 9;
            }
            Console.WriteLine($"Цена: {Price} руб.");
        }
    }
}
