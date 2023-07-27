// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве

Console.Clear();
int a_x, a_y, a_z, b_x, b_y, b_z;

try 
{
    Console.Write("Введите координату X первого числа: ");
    a_x = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите координату Y первого числа: ");
    a_y = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите координату Z первого числа: ");
    a_z = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите координату X второго числа: ");
    b_x = int.Parse(Console.ReadLine() ?? "");
    
    Console.Write("Введите координату Y второго числа: ");
    b_y = int.Parse(Console.ReadLine() ?? "");

    Console.Write("Введите координату Z второго числа: ");
    b_z = int.Parse(Console.ReadLine() ?? "");  
}

catch (Exception)
{
    Console.WriteLine("Ошибка ввода данных");
    return;
}

double distance = Math.Sqrt(Math.Pow(b_x - a_x, 2) + Math.Pow(b_y - a_y, 2) + Math.Pow(b_z - a_z, 2));

Console.WriteLine($"A({a_x}, {a_y}, {a_z}); B({b_x}, {b_y}, {b_z}) -> {distance}");