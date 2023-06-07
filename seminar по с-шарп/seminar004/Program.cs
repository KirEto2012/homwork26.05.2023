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
/*
Console.WriteLine("Ввидите чесло - A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите чесло - B: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Натуральноя степинь:");

GetSumOfTwoNumbers(numA, numB);

void  GetSumOfTwoNumbers(int numberA, int numberB)
{
       int sum = 1;

    for (var i = 1; i <= numberB; i++)
    {
        //sum *= i;
        //Анологично
        sum = sum * numberA;
    }
    Console.WriteLine(sum);
}
*/
/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12


Console.WriteLine("Ввидите чесло: ");
int numA = int.Parse(Console.ReadLine());
int sum = GetSumOfTwoNumbers(numA);
Console.WriteLine(sum);

int GetSumOfTwoNumbers(int numberA)
{
    int sum = 0;
    while (numberA > 0)
    {
        sum += numberA %10;
        numberA = numberA /10;
    
    }
    return sum;
}
*/

/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]


Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series){
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

      }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew){ 

  int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1){
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
  }
  return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
*/
