/*
10.06.2023
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ArrayRandomNumbers(numbers);
Console.WriteLine();
PrintArray(numbers);

void ArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] numbers)

{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
        {
            max = numbers[z];
        }
        if (numbers[z] < min)
        {
            min = numbers[z];
        }
    }

    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine($"] => {max}, {min} = {max - min}");

}
