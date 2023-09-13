using Lesson30;

SmartphoneGadjet smartphone = new SmartphoneGadjet("Iphone 11", "Apple", 256, 4, 30000, 12);
smartphone.WriteShortInfo();
smartphone.ShowOptPrice();

Console.WriteLine();
TabletGadjet tablet = new TabletGadjet("Ipad", "Apple", 128, 6, 55000, 10, "нет");
tablet.WriteShortInfo();
tablet.ShowOptPrice();

Console.WriteLine();
NotebookGadjet notebook = new NotebookGadjet("Macbook", "Apple", 1000, 16, 95000, 24);
notebook.WriteShortInfo();
notebook.ShowOptPrice();