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
        public string Sound { get; private set; }

        public string _food;
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
                Sound = _soundEleph;
            }
            if (title == "Пингвин")
            {
                Sound = _soundPeng;
            }
            if (title == "Тигр")
            {
                Sound = _soundTiger;
            }
        }
        public string GetFoodType(string title, string food)
        {
            if (title == "Слон")
            {
                food = _foodEleph;
            }
            if (title == "Пингвин")
            {
                food = _foodPeng;
            }
            if (title == "Тигр")
            {
                food = _foodTiger;
            }
            return food;
        }
        public void DoEat(string food)
        {
            Console.WriteLine($"{Title} {Name} съел {food}");
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
