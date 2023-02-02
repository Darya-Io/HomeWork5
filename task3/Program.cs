// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int len = 5)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 1000);
    }
    return array;
}
void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}
double[] array = GenerateArray();
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");



