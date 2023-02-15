// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int[] array = new int[5];


void FillArray(int[] array)
{
    Console.WriteLine("Enter five counts: ");
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
FillArray(array);

int ZeroCount(int[] array)
{
    int temp = 0;
    int index = 0;
    while (index < array.Length)
    {
        if (array[index] > 0)
        {
            temp++;
        }
        index++;
    }
    Console.WriteLine($"Counts more than zero = {temp}");
    return temp;
    
}
ZeroCount(array);
