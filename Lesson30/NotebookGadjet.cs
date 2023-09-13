using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30
{
    public class NotebookGadjet:AbstractGadjet
    {
        public int Battery { get; set; }
        public NotebookGadjet(string title, string manufacturer, int memory, int display, int price, int battery)
        {
            Title = title;
            Manufacturer = manufacturer;
            Memory = memory;
            Display = display;
            Price = price;
            Battery = battery;
        }
        public override void ShowOptPrice()
        {
            Console.WriteLine("Введите количество товара");
            int quantity = Convert.ToInt32(Console.ReadLine());
            if (quantity >= 5)
            {
                Price = Price - Price / 100 * 5;
            }
            Console.WriteLine($"Цена: {Price} руб.");
        }
    }
}
