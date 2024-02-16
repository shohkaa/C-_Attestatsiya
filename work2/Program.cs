// Задача №2.
// Напишиите программу, вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных чисел m и n.
// Пример
// m=2, n=3 => A(m,n)=29;


int CalculateFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return CalculateFunction(n - 1, 1);
    else
        return CalculateFunction(n - 1, CalculateFunction(n, m - 1));
}

Console.Write("Введите значение m для функции Аккерманa: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значения n для функции Аккермана: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = CalculateFunction(num2, num1);
Console.Write($"Вычисление завершено, результат равен: {result}");
