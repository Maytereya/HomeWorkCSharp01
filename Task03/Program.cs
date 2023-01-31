/*
Задача 6. Проверка четности числа.
*/
Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n%2 == 1)
    Console.WriteLine ("Нечетное");
else 
    Console.WriteLine ("Четное");