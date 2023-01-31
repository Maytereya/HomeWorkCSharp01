/*
Задача 8. На вход принимает число N и выдает все четные числа от 1 до N.
*/
Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine()), count = (2);
while (n <= 0)

{ 
Console.Write("Вы ошиблись, введите число, которое больше 0: ");
n = Convert.ToInt32(Console.ReadLine());

}
//Console.WriteLine(count+=2);
while (count <= n)
{
    Console.Write ($"{count} ");
    count+=2;

}