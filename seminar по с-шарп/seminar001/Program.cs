/*
int numA = Calculete(1, 3);
int numB = Calculete(86701423, 1345987);
bool isEqual = CheckEqual(1, 3);

if (isEqual)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
int Calculete(int a, int b)
{
    return a + b;
}
bool CheckEqual(int a, int b)
{
    return a == b;
}
*/
/*
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

int result = Determine(numA,numB);

if(result == -1){
    Console.WriteLine("Одна из кординат равна нулю");
    return;
}

Console.WriteLine(Determine);

int Determine(int numA, int numB)
{
    if (numA > 0 & numB > 0)
    {
        return 1;
    }

    if (numA < 0 & numB > 0)
    {
        return 2;
    }
    if (numA < 0 & numB < 0)
    {
       return 3;
    }
    if (numA > 0 & numB < 0)
    {
       return 4;
    }

    return -1 ;
}
*/

int numberA = int.Parse(Console.ReadLine());

string range = GitRengeByQuarternumber(numberA);

string range2 = GitRengeByQuarternumber(numberA);

Console.WriteLine(range);
Console.WriteLine(range2);

string GitRengeByQuarternumber(int numberA)
{
    if (numberA == 1)
    {
        return "x > 0 & y > 0";
    }
    if (numberA == 2)
    {
        return "x < 0 & y > 0";
    }
    if (numberA == 3)
    {
        return "x > 0 & y > 0";
    }
    if (numberA == 4)
    {
        return "x > 0 & y < 0";
    }
    switch (numberA)
    {
        case 1: return "x > 0 & y > 0";
        case 2: return "x < 0 & y > 0";
        case 3: return "x < 0 & y < 0";
        case 4: return "x > 0 & y < 0";
        default: return "некоректное число";
    }
    return string.Empty;
}

string GitRengeByQuarternumberSwitch(int numberA)
{
   switch (numberA)
    {
        case 1: return "x > 0 & y > 0";
        case 2: return "x < 0 & y > 0";
        case 3: return "x < 0 & y < 0";
        case 4: return "x > 0 & y < 0";
        default: return "некоректное число";
    }
}