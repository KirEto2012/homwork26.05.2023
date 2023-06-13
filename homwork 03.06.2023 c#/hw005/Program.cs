/*
10.06.2023
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int size = 4;
int[] number = new int[size];
ArrayRandomNumbers(number);
Array(number);

void ArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void Array(int[] array)
{
    int Index = 0;

    Console.WriteLine();

    for (int i = 1; i < number.Length; i += 2)
    {
        Index += number[i];
    }

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine($"] = {Index}");

    Console.WriteLine();

}
