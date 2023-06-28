/*
// вринцыпи дз 64
int n = int.Parse(Console.ReadLine()); // вводим чисо n

PrintNumber(n);

void PrintNumber(int n)
{
    if(n < 1) // устонавливоем условия если n меньше 1 то мы остонавливаем цыкал
    {
        return;
    }
    Console.WriteLine(n);
    
    PrintNumber(--n); // каждый раз от числа n отнимаем 1
    
}
*/
/*
int n = int.Parse(Console.ReadLine()); // вводим чисо n

PrintNumber(n);

void PrintNumber(int n )
{
    int number = n - 1;
    if (n < 1) // устонавливоем условия если n меньше 1 то мы остонавливаем цыкал
    {
        return;
    }

    PrintNumber(number); // каждый раз от числа n отнимаем 1
    Console.Write($"{n} ");
}
*/
/*
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

PrintNumbersInRange(m, n);

void PrintNumbersInRange(int m, int n)
{
    if (m > n)
    {
        return;
    }

    Console.Write($"{m} ");
    PrintNumbersInRange(++m, n);
}
*/
/*
int number = int.Parse(Console.ReadLine());

int sum = GetSumOfDigitsInNumber(number);

Console.WriteLine($"Суььф чисел в чесле ровна - {sum}");

int GetSumOfDigitsInNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }


    return GetSumOfDigitsInNumber(number / 10) + number % 10;

}
*/

int a = int.Parse(Console.ReadLine());

int b = int.Parse(Console.ReadLine());

int result = Pow(a, b);
Console.WriteLine(result);

int Pow(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }

    return Pow(a, --b) * a;

}










