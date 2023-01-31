/*
Задача 2. На вход принимает два числа и выдает какое из чисел больше, 
а какое меньше.
*/
Console.Clear();

Console.Write("Введите 1е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
    Console.WriteLine ($"Число {n} больше чем {m}");
else if (n < m) 
    Console.WriteLine ($"Число {m} больше чем {n}");
else 
    Console.WriteLine ("введенные числа равны");