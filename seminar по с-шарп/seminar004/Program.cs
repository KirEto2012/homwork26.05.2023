/*
int a = int.Parse(Console.ReadLine());
int sum = GetSumNumbersUpToNumber(a);

Console.WriteLine(sum);

int GetSumNumbersUpToNumber(int number)
{
    int sum = 0;

    for (var i = 1; i <= number; i++)
    {
        sum += i;
        //Анологично
        //sum = sum + i
    }

    return sum;
}
*/
/*
int a = int.Parse(Console.ReadLine());

int count = GetNumberOfDigits(a);

Console.WriteLine(count);

int  GetNumberOfDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }


    return count;
}
*/
/*
int n = int.Parse(Console.ReadLine());
int result = Factorial(n);

Console.WriteLine(result);

int Factorial(int n)
{
    int result = 1;

    for (var i = 2; i <= n; i++)
    {
        result*= i;
    }
    return result;
}
*/
/*
int Length = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(Length);

//Console.WriteLine(string.Join(",", array));
PrintArray(array);

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write("");
    }
}

int[] GetRandomArray(int Length)
{
    int[] array = new int [Length];
    
     Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0,2);
    }
    return array;
}
*/



