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

// Решение медотом преобразования числа в массив, сортировки и обратного преобразования

int InputNum(string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int CountDigit(int number) // считаем кол-во цифр в числе
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

void ConvertNumberToArray(int[] collection, int length, int number) // преобразовываем число в массив натуральных элементов
{
    int index = length - 1;
    while (index > 0)
    {
        collection[index] = number % 10;
        number = number / 10;
        index--;
    }
    collection[0] = number;
}

void SortArray(int[] collection) //сортируем элементы массива, сначала нечетные потом четные
{
    int buffer = collection[0];
    int firstEvenDigit = collection[0];
    bool needToSort = false;
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        if (collection[index] % 2 == 0)
        {
            firstEvenDigit = index;
            needToSort = true;
            break;
        }
        index++;
    }
    
    index = firstEvenDigit;
    if (needToSort)
    {
        while (index < length - 1)
        {
            if (collection[index] % 2 == 0 && collection[index + 1] % 2 != 0)
            {
                buffer = collection[index];
                collection[index] = collection[index + 1];
                collection[index + 1] = buffer;
                if (index > firstEvenDigit) index = firstEvenDigit;
                else 
                {
                firstEvenDigit++;
                index = firstEvenDigit;
                }
            }
            else
            {
                index++;
            }

        }
    }
}

int ArrayToNumber(int[] collection) // преобразовываем массив в число
{
    int count = 0;
    int length = collection.Length;
    int result = 0;
    while (count < length)
    {
        result = result * 10 + collection[count];
        count++;
    }
    return result;
}

Console.Clear();

Console.WriteLine("Данная программа преобразовывает число таким образом, чтобы все нечетные числа стояли впереди, а все четные позади");
int num = InputNum("Введите любое целое число: ");

int[] array = new int[CountDigit(num)];
ConvertNumberToArray(array, CountDigit(num), num);
SortArray(array);
Console.WriteLine();
Console.WriteLine($"Число с правильным заданным порядком выглядит так {ArrayToNumber(array)}");
