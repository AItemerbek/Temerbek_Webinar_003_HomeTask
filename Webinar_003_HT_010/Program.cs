// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int SecondDigitReturn(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}

Console.Clear();

int num = InputNum("Введите число трехзначное число: ");
int result = SecondDigitReturn(num);

Console.WriteLine($"Вторая цифра в числе {num} это {result}");
