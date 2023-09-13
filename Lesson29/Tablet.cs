using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29
{
    public class Tablet : Smartphone
    {
        public string Stylus { get; set; }
        public Tablet(string title, string manufacturer, int memory, int display, int price, int camera, string stylus) : base(title, manufacturer, memory, display, price, camera)
        {
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

