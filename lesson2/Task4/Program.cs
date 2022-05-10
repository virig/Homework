// Рандомное число, одновременно кратно числу 7 и 23, да или нет.
int number = new Random().Next(1, 999);
int a = 7;
int b = 23;

string txtResult = " ";

if (number % a == 0 && number % b == 0) txtResult = "Кратно обоим числам";
else if (number % a != 0 && number % b !=0) txtResult = "не кротно ни одному из чисел";
else if (number % a == 0) txtResult = $"кратно только числу {a}";
else txtResult = $"кратно только числу {b}";

System.Console.WriteLine($"Проверить кратность чисел {a} и {b} ");
System.Console.WriteLine();
System.Console.WriteLine($"Числа {number} {txtResult} ");
System.Console.WriteLine();
