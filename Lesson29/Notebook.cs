using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29
{
    public class Notebook : Tablet
    {
        public int Battery { get; set; }
        public Notebook(string title, string manufacturer, int memory, int display, int price, int camera, string stylus, int battery) : base(title, manufacturer, memory, display, price, camera, stylus)
        {
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
