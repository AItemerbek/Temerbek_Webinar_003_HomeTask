// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void ThirdDigitReturn(int number)
{
    int result = number;
    if (result < 0) result = -result; // проверка на случай ввода отрицательного числа.
    if (result >= 100)
    {
        while (result >= 1000) result = result / 10; // делим число на 10 без учета остатка, пока не получим трехзначное
        int thirdDigit = result % 10;
        Console.WriteLine($"Третья цифра в числе {number} это {thirdDigit}");
    }
    else Console.WriteLine($"Третьей цифры в числе {number} нет");
}

Console.Clear();

int num = InputNum("Введите любое целое число: ");
ThirdDigitReturn(num);
