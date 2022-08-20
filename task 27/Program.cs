Console.WriteLine("Введите число");
string In = (Console.ReadLine()!);
char[] ar = In.ToArray<char>();
int i = 0;
int Out = 0;
do
{
    Out = Out + ((int)Char.GetNumericValue(ar[i]));
    i++;
} while (i <= ar.Length - 1);
Console.WriteLine("Сумма всех чисел: " + Out);