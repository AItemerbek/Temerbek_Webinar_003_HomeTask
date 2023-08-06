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

int ThirdDigitReturn(int number)
{
    int thirdDigit = number % 10;
    return thirdDigit;
}

int ConvertNumber(int number) // вспомогательная функция для отбрасывания всех цифр после 3-ей
{
    while (number >= 1000) number = number / 10;
    return number;
}

Console.Clear();

int num = InputNum("Введите любое целое число: ");
int result = num;

if (result < 0) result = -result; // проверка на случай ввода отрицательного числа.

if (result >= 100)
{
    int thirdDigit = ThirdDigitReturn(ConvertNumber(result));
    Console.WriteLine($"Третья цифра в числе {num} это {thirdDigit}");
}
else Console.WriteLine($"Третьей цифры в числе {num} нет");
