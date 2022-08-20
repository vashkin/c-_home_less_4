// See https://aka.ms/new-console-template for more information

int NumPow (int number, int pow){
int num = number;
int i = 2;
do {
number=number*num;
i++;
}while(i<=pow);
return number;
}

Console.WriteLine (NumPow(3,5));
Console.WriteLine (NumPow(2,4));