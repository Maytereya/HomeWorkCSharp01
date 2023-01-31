/*
На вход принимает два числа и выдает какое из чисел больше, 
а какое меньше.
*/
Console.Clear();

Console.Write("Введите 1е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
    Console.WriteLine ($"Число {n} больше чем {m}");
else if (n < m)   //Выполняется это условие и дальше проверка не идет.
    Console.WriteLine ($"Число {m} больше чем {n}");
else // выполняется это условие отдельно. 
// Если сверху не ставить else if, то программа продолжит проверять условия и выведет результат  из else тоже
    Console.WriteLine ("введенные числа равны");

/*int m = int.Parse(Console.ReadLine()); выгоднее с точки зрения использования памяти. тк использует ту же ячейку памяти.
string? name = Console.ReadLine();

Console.WriteLine($"Результат умножения: {n*5}"); //Строка с интерполяцией данных. В скобках указано выражение, которое работает не как строка. 
*/