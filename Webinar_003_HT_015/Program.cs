// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

bool ValidateWeekend(int number)
{
    if (number < 8)
    {
        if (number > 5) return true;
        else
        {
            Console.WriteLine("Это рабочий день");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Такого дня недели не существует");
        return false;
    }

}

Console.Clear();

int num = InputNum("Введите номер дня недели: ");
if (ValidateWeekend(num)) Console.WriteLine("Это выходной день");
