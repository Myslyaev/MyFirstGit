using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson27
{
    public class Animal
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public int Area { get; set; }
        public string Biom { get; set; }
        public string Food { get; private set; }
        public string Sound { get; private set; }

        private const string _foodEleph = "Рыба";
        private const string _soundEleph = "Ауф";
        private const string _foodPeng = "Мясо, сено";
        private const string _soundPeng = "Хрю";
        private const string _foodTiger = "Мясо";
        private const string _soundTiger = "Рррр";

        public Animal(string name, string title, int age, int area, string biom)
        {
            Name = name;
            Title = title;
            Age = age;
            Area = area;
            Biom = biom;
            if (title == "Слон")
            {
                Food = _foodEleph;
                Sound = _soundEleph;
            }
            if (title == "Пингвин")
            {
                Food = _foodPeng;
                Sound = _soundPeng;
            }
            if (title == "Тигр")
            {
                Food = _foodTiger;
                Sound = _soundTiger;
            }
        }
        public void DoEat()
        {
            Console.WriteLine($"{Title} {Name} съел {Food}");
        }
        public void DoVoice()
        {
            Console.WriteLine($"{Title} {Name} прокричал {Sound}");
        }
        public void DoGame()
        {
            Console.WriteLine($"{Title} {Name} поиграл");
        }
    }
}
