/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Впишыте чесло a");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Впишыте чесло b");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("число под буквой a=" + numberA + " больше чем число под буквлй b=" + numberB);
}
else
{
    Console.WriteLine("число под буквой b=" + numberB + " больше чем число под буквлй a=" + numberA);
}