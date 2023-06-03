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
/*
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
*/
/*
Console.WriteLine("Ввидите координату x1,y1");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите координату x2,y2");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
*/

Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ввидите координату x2,y2,z2");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine());


double distance = DistancePoints(x1, y1, x2, y2, z1, z2);

Console.WriteLine("Растояниемеждву 2 точками равно =");
Console.Write(Math.Round(distance, 3));

double DistancePoints(int x1, int y1,int x2, int y2,int z1, int z2)
{
    //a^2 = b^2 + c^2
    //double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

/*
Console.WriteLine("Ввелите число");
Console.Write("number = ");
int n = int.Parse(Console.ReadLine());

PrintSquares(n);

int [] result = GetSquares(n);

Console.WriteLine();

Console.WriteLine(string.Join(" ", result));

void PrintSquares(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.Write(i * i);
        Console.Write(" ");
    }
}

int[] GetSquares(int number)
{
    int[] tableOFSquares =  new int [number];

    for(int i = 0; i < tableOFSquares.Length; i++)
    {
        int tmp = i + 1;
        tableOFSquares[i] = tmp * tmp;
    }
    return tableOFSquares; 
}
*/
/*
Console.WriteLine("Ввелите число");
Console.Write("number = ");
int n = int.Parse(Console.ReadLine());

PrintSquares(n);

int [] result = GetSquares(n);

Console.WriteLine();

Console.WriteLine(string.Join(" ", result));

void PrintSquares(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.Write(i * i);
        Console.Write(" ");
    }
}

int[] GetSquares(int number)
{
    int[] tableOFSquares =  new int [number];

    for(int i = 0; i < tableOFSquares.Length; i++)
    {
        int tmp = i + 1;
        tableOFSquares[i] = tmp * tmp;
    }
    return tableOFSquares; 
}

*/