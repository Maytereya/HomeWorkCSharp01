/*
На вход принимает три числа и выдает максимальное.
*/
Console.Clear();

Console.Write("Введите 1е число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2е число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3е число: ");
int k = Convert.ToInt32(Console.ReadLine());

if (n > m && n > k)
    Console.WriteLine ($"Число {n} самое большое");
else if (m > n && m > k)   //Выполняется это условие и дальше проверка не идет.
    Console.WriteLine ($"Число {m} самое большое");
else if (k > n && k > m)   //Выполняется это условие и дальше проверка не идет.
    Console.WriteLine ($"Число {k} самое большое");

else // выполняется это условие отдельно. 
// Если сверху не ставить else if, то программа продолжит проверять условия и выведет результат  из else тоже
    Console.WriteLine ("Введенные числа равны");

/*int m = int.Parse(Console.ReadLine()); выгоднее с точки зрения использования памяти. тк использует ту же ячейку памяти.
string? name = Console.ReadLine();

Console.WriteLine($"Результат умножения: {n*5}"); //Строка с интерполяцией данных. В скобках указано выражение, которое работает не как строка. 
*/
