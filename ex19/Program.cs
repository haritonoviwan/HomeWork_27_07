// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.Clear();

int number = 0;
try
{
    Console.Write("Введите пятизначное число: ");
    number = int.Parse(Console.ReadLine() ?? "");
}

catch (Exception exc)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Введенное число не пятизначное");
}
else
{
    int original_number = number;
    int reversed_number = 0;
    while (number > 0)
    {
        int digit = number % 10;
        reversed_number = reversed_number * 10 + digit;
        number = number / 10;
    }

    if (original_number == reversed_number)
    {
        Console.WriteLine($"{original_number} -> да");
    }
    else 
    {
        Console.WriteLine($"{original_number} -> нет");
    }
}