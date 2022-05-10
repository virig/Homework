
// вывод второго числа из случайного трехзначного числа
System.Console.WriteLine();
int number = new Random().Next(100, 999);

System.Console.WriteLine($"Вторая цифра числа {number} является {number / 10 % 10} ");

System.Console.WriteLine(); 