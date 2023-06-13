﻿/*
//Задачя 39
int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
//вызываем масив
PrintArray(array);
//вызываем реверсивный масив
Reverse(array);
//вызываем масив
PrintArray(array);


//метод по перивороту масива
void Reverse(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        //int tmp = array[array.Length - 1 - i];
        //array[array.Length - 1 - i] = array[i];
        //array[i] = tmp;
        //альтернотивноя версия [array[array.Length - 1 - i] = array[i];]
        int tmp = array[^(i + 1)];
        array[^(i + 1)] = array[i];
        array[i] = tmp;
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}
*/
/*
// ЗАдачя 40 
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Console.WriteLine(CheckSum(a, b, c));

bool CheckSum(int a, int b, int c)
{
    return a < b + c & b < a + c & c < b + a;
}
*/

//Задачя 41
int number = int.Parse(Console.ReadLine());

string result = ToBinery(number);
Console.WriteLine(result);

string ToBinery (int number)
{
    string result = string.Empty;
    while (number != 0)
    {
        result += number % 2;
        number = number / 2;
        return result;
    }
}


