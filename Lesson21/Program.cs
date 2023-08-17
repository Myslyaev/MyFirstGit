using Lesson21;

int quantity=Restaurant.ReadMenuQuantity();
int[] ordersQuantity = new int[quantity];
ordersQuantity = Restaurant.ReadOrdersQuantity(ordersQuantity);
ordersQuantity = Restaurant.SortOrdersQuantity(ordersQuantity);
Restaurant.WriteOrdersQuantity(ordersQuantity);




