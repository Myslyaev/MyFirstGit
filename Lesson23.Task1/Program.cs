GetAndSortRating();

 static void GetAndSortRating()
{
    List<int> ratingList = new List<int>();

    Console.WriteLine("Введите рейтинг сотрудника по одному, в конце напишите слово: конец");
    string rating;
    while ((rating = Console.ReadLine()) != "конец")
    {
        ratingList.Add(Convert.ToInt32(rating));
    }

    int max = ratingList[0];
    foreach (int i in ratingList)
    {
        if (max < i)
        {
            max = i;
        }
    }

    Console.WriteLine($"Самый высокий рейтинг: {max}");
}