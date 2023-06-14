/*
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
/*
//Задачя 41
int num = int.Parse(Console.ReadLine());
string result = ToBinary(num);
Console.WriteLine(result);
string ToBinary(int nim)
{
    string result = string.Empty;
    while (num != 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
*/
/*
// Задачя 44
int n = int.Parse(Console.ReadLine());

PrintFibonacciNumbers(n);

void PrintFibonacciNumbers(int n)
{
    int firstNumber = 0;
    int secondNumber = 1;


    if (n == 1)
    {
        Console.Write("0 ");
        return;
    }
    if (n > 1)
    {
        Console.Write("0 1 ");
       
    }

    int sum = 0;
    for (var i = 2; i < n; i++)
    {
        sum = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = sum;
        Console.Write(sum);
        Console.Write(" ");
    }
}
*/
//задачя 45
/*
int[] array = new int[] { 1, 2, 3, 4, 5, 6 };


int a = 5;
int b = a;

b++;

Console.WriteLine(a);
Console.WriteLine(b);
*/
int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
int[] array2 = copy(array);

array2[1] = 123;

PrintArray(array);
PrintArray(array2);

int[] copy(int[]array)
{
    int[] result = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ,", array));
}






