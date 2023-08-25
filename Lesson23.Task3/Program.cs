GetAndWriteRating();

static void GetAndWriteRating()
{
    Console.WriteLine("Введите план продаж");
    int salesPlan = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите сумму продаж каждого сотрудника по одному, в конце напишите слово: конец");

    List<int> ratingList = new List<int>();
    string salesSummary;
    while ((salesSummary = Console.ReadLine()) != "конец")
    {
        ratingList.Add(Convert.ToInt32(salesSummary));
    }

    int lessThanPlan = 0;
    foreach (int i in ratingList)
    {
        if (i<salesPlan)
        {
            lessThanPlan++;
        }
    }
    
    Console.WriteLine($"Количество сотрудников не выполнивших план: {lessThanPlan}");
}