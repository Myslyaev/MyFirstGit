using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson30
{
    public abstract class AbstractGadjet
    {
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public int Memory { get; set; }
        public int Display { get; set; }
        public int Price { get; set; }
        public void WriteShortInfo()
        {
            Console.WriteLine($"{Title} {Manufacturer}: {Price} руб.");
        }
        public abstract void ShowOptPrice();
    }
}
