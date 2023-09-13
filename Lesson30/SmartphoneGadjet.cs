namespace Lesson30
{
    public class SmartphoneGadjet:AbstractGadjet
    {
        public int Camera { get; set; }
        public SmartphoneGadjet(string title, string manufacturer, int memory, int display, int price, int camera)
        {
            Title = title;
            Manufacturer = manufacturer;
            Memory = memory;
            Display = display;
            Price = price;
            Camera = camera;
        }

        public override void ShowOptPrice()
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
