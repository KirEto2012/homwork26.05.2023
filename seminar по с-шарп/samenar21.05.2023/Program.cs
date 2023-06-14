/*
int randomNumberA = int.Parse(Console.ReadLine());
int randomNumberB = int.Parse(Console.ReadLine());
int lastDigit = randomNumberB % 10;
int first = randomNumberA / 10;

Console.WriteLine(randomNumberA);

if (first >= lastDigit)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(lastDigit);
}

*/





int randomNumberA = int.Parse(Console.ReadLine());

int lastDigit =randomNumberA % 10 ;

int first = randomNumberA / 100 ;


Console.WriteLine(first * 10 + lastDigit);





/*
int firstNimber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int remainder = firstNimber % secondNumber;

if (remainder == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"не кратно - остаток {remainder}");
}
*/






/*
int number = int.Parse(Console.ReadLine());
if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine("да");

}
else
{
Console.WriteLine("No");
}
*/




/*
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

int first = numberA * numberA;
int second = numberB * numberB;

if (first == numberB | second == numberA)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

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