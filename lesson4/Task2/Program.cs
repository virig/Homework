// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int sum = 0;
int n = 5168;

while (n > 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine(sum);
