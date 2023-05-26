/*
 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Ввидете чесле a: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Ввидете чесле b: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Ввидете чесле c: ");
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine("Max число:" + numberA);
    }
    else
    {
        Console.WriteLine("Max число:" + numberC);
    }
}

else if (numberB > numberC)
{
    Console.WriteLine("Max число:" + numberB);
}
else
{
    Console.WriteLine("Max число: " + numberC);
}