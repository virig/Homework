﻿Console.Clear();

int Number = new Random().Next(10, 99);
int Max = 0;

int MaxDigit()
{
    int DigitOne = Number / 10;
    int DigitTwo = Number % 10;
    if (DigitOne > DigitTwo) Max = DigitOne;
    else Max = DigitTwo;

    return Max;
}

MaxDigit();
System.Console.WriteLine();
System.Console.WriteLine($"В числе {Number} наибольшая цифра {Max}");
System.Console.WriteLine();
