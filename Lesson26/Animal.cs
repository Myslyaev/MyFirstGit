using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Title { get; set; }
        public string Biom { get; set; }
        public int Area { get; set; }
        public string Food { get; set; }
        public string Voice { get; set; }
        public void DoEat()
        {
            Console.WriteLine($"{Name} ест {Food}");
        }
        public void DoVoice()
        {
            Console.WriteLine($"{Name} издает {Voice}");
        }
        public void DoGame()
        {
            Console.WriteLine($"{Name} играет");
        }
    }
}
