// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int number = 3;
int exponent = 7;
int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

System.Console.WriteLine($"{number} ^ {exponent} = {result}");
System.Console.WriteLine();