/*
10.06.2023
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
//RandonNumber(number);
Console.Write($" массив состоит из {number.Length} чисел:");
RandonNumber(number);
Print(number);

void RandonNumber(int[] number)
{
    for(int i = 0; i < size; i++)
    {
        number[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < number.Length; x++)
{
if (number[x] % 2 == 0)
count++;
}
Console.WriteLine($" и чётными являются {count} из них.");

void Print(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {

        Console.Write(num[i] + " ");
    }
    Console.Write("]");
}
