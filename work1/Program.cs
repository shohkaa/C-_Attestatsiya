// Задача №1.
// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от М до N. 
// Использовать рекурсию, не использовать циклы.
// ПРИМЕР
// М=1; N=5; => *1,2,3,4,5*
// M=4; N=8; => *4,5,6,7,8*

void NaturalNumbers(int num1, int num2)
{
    if(num1 > num2 )
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 - 1, num2);
    }
    else if(num1 < num2)
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 + 1, num2);
    }
    else
    {
        Console.Write($"{num1}");
    }
}


Console.Write("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine()); 

NaturalNumbers(M, N);