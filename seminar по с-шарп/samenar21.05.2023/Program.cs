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

