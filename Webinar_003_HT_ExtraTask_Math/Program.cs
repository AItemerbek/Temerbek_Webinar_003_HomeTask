// Программа на вход получает натуральное число. Необходимо его преобразовать таким образом, чтобы все нечетные числа стояли впереди, а все четные позади. 
// При этом внутри четных и нечетных чисел очередность должна сохраняться. Результатом должно быть новое число, а не просто вывод на печать цифр в нужном порядке. 
// Использовать можно только арифметические действия без работы со строкой.
// Пример:
// 12345 -> 13524
// 3658563 -> 3553686
// 48 -> 48
// 5497 -> 5974
// Для решения может понадобится функция возведения в степень и приведение типов. По крайней мере мне они понадобились:
// Чтобы возвести в степень число используйте функцию Math.Pow(value, degree), где value - число, которое возводят в степень, а degree - собственно степень.
// Эта функция возвращает double. Если нужно привести полученный результат к int, используйте следующую конструкцию: (int)Math.Pow(value, degree)

// Решение с ипользованием математических вычеслений

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int CountEvenDigit(int number) // считаем кол-во четных цифр в числе
{
    int count = 0;
    int evenDigit = 0;
    while (number > 0)
    {
        if (number % 2 == 0) evenDigit++;
        number = number / 10;
    }
    return evenDigit;
}

int SortingDigit(int calcEvenkDigit, int num)
{
    int number = 0;
    int indexEven = 0;
    int indexOdd = calcEvenkDigit;
    while (num > 0)
    {
        if (num % 10 % 2 == 0)
        {
            number = number + num % 10 * (int)Math.Pow(10, indexEven);
            indexEven++;
        }
        else
        {
            number = number + num % 10 * (int)Math.Pow(10, indexOdd);
            indexOdd++;
        }
        num = num / 10;
    }
    return number;
}

Console.Clear();

Console.WriteLine("Данная программа преобразовывает число таким образом, чтобы все нечетные числа стояли впереди, а все четные позади");
int num = InputNum("Введите любое целое число: ");
Console.WriteLine();
Console.WriteLine($"Число с правильным заданным порядком выглядит так {SortingDigit(CountEvenDigit(num), num)}");
