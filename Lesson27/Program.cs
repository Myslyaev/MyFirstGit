using Lesson27;
Animal animal = new Animal("Петя", "Слон", 5, 10, "Тропики");
string food = animal._food;
string title = animal.Title;
food = animal.GetFoodType(title, food);
animal.DoEat(food);
animal.DoVoice();
animal.DoGame();

Console.WriteLine();
animal = new Animal("Симба", "Пингвин", 1, 10, "Тундра");
title = animal.Title;
food = animal.GetFoodType(title, food);
animal.DoEat(food);
animal.DoVoice();
animal.DoGame();

Console.WriteLine();
animal = new Animal("Матильда", "Тигр", 20, 10, "Пустыня");
title = animal.Title;
food = animal.GetFoodType(title, food);
animal.DoEat(food);
animal.DoVoice();
animal.DoGame();