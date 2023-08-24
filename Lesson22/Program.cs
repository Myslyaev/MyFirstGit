using Lesson22;

int countDays = Cinema.GetCountDays();
int countFilms = Cinema.GetCountFilms();
int[,] filmsPopularityArr = Cinema.InputFilmsPopularityArr(countDays, countFilms);
Cinema.ShowFilmsPopularityArr(filmsPopularityArr);
Cinema.GetFilmsSum(filmsPopularityArr);