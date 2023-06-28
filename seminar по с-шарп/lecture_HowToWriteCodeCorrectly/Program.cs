//
/*
void Method(int maximum)
{
    int minmimum;
    minmimum = -maximum;
    while (minmimum <= maximum)
    {
        Console.WriteLine(minmimum + "");
        minmimum++;
    }
}
//
int[] CreatrArray(int N)
{
    int[] arrayA = new int[N * 2 + 1];
    for (int i = -N; i <= N; i++)
    {
        arrayA[i + N] = i;
    }
}
return arrayA;
//
int Ar(int N) // задаём метод
{
    int x = -N; // первая цыфра -N (задаём цикл)
    while (x <= N) // до тех пор пока x меньше или равен N
    {
        Console.WriteLine(x); // выводим в консоль "x"
            x++; // инкримент
    }
}
return x;
//
void Numbers(int n)
{
    int length = n + n;
    for (int i = 0; i < length + 1; i++)
    {
        Console.WriteLine(-n +i);
    }
}
//
string ShowNums(int N)
{
    string NumsShow = "";
    for (int i = -N; i < N; i++)
    {
        NumsShow = NumsShow + i + "";
    }
}
return NumsShow;
//
int af = -5;
int uf = 5;
Console.WriteLine($"{af} .. {uf}");
*/

using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
            .Replace("(", "")
            .Replace(")", "")
            ;
Console.WriteLine(text);

var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                .Where(e => e.x % 2 == 0)
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
    Console.WriteLine();
}

