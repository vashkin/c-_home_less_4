// See https://aka.ms/new-console-template for more information
int[] number = new int[8];
int i = 0;
Console.Write("[");
do
{
    number[i] = new Random().Next(0, 100);

    Console.Write("" + number[i]);
    i++;
    if (i != 0 & i != number.Length)
    {
        Console.Write(",");
    }
} while (i <= number.Length - 1);

Console.Write("]");