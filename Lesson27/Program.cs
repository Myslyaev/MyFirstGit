using Lesson27;
Animal animal = new Animal("Петя", "Слон", 5, 10, "Тропики");
animal.DoEat();
animal.DoVoice();
animal.DoGame();

Console.WriteLine();

animal = new Animal("Симба", "Пингвин", 1, 10, "Тундра");
animal.DoEat();
animal.DoVoice();
animal.DoGame();

Console.WriteLine();

animal = new Animal("Матильда", "Тигр", 20, 10, "Пустыня");
animal.DoEat();
animal.DoVoice();
animal.DoGame();