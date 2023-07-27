// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int counter = 1;
int total = 1;
int number = 0;
try 
{
    Console.Write("Введите число: ");
    number = int.Parse(Console.ReadLine() ?? "");
}

catch (Exception)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}

Console.Write($"{number} -> ");

while (counter <= number)
{
    total  = counter * counter * counter;
    counter++;
    Console.WriteLine(total);
}