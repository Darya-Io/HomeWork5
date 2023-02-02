// Задача 2: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len = 5)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}
int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}
int[] array = GenerateArray();
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих под нечетными индексами равна:{SumOddIndex(array)}");




