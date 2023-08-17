using Lesson21;

int numberOfDishes=Restaurant.ReadMenuQuantity();
int[] ordersQuantityArr = new int[numberOfDishes];
ordersQuantityArr = Restaurant.ReadOrdersQuantity(ordersQuantityArr);
ordersQuantityArr = Restaurant.SortOrdersQuantity(ordersQuantityArr);
Restaurant.WriteOrdersQuantity(ordersQuantityArr);




