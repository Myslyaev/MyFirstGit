using Lesson29;

Smartphone smartphone = new Smartphone("Iphone 11", "Apple", 256, 4, 30000, 12);
smartphone.WriteShortInfo();
smartphone.ShowOptPrice();

Console.WriteLine();
Tablet tablet = new Tablet("Ipad", "Apple", 128, 6, 55000, 10, "нет");
tablet.WriteShortInfo();
tablet.ShowOptPrice();

Console.WriteLine();
Notebook notebook = new Notebook("Macbook", "Apple", 1000, 16, 95000, 10, "да", 24);
notebook.WriteShortInfo();
notebook.ShowOptPrice();
