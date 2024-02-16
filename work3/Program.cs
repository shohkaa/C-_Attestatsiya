// Задача №3.
// Задайте произвольный массив.
// Выведете элементы, начиная с конца. 
// Испозовать рекурсию, не использовать циклы.
// Пример 
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1




void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + " ");
        }
    }
    Console.Write("]");
}

void PrintReverseArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        Console.Write(array[i] + " ");
        return;
    }
    
    PrintReverseArray(array, i + 1);
    Console.Write(array[i] + " ");
}

int[] array = {1, 2, 5, 0, 10, 34};
PrintArray(array);
Console.Write($" => ");
PrintReverseArray(array, 0);