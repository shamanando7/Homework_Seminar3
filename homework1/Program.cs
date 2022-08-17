// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string? numberString = Console.ReadLine()!;
int n = int.Parse(numberString);

int dig = 0;
int rev = 0;
int temp = n;

while (n > 0)
{
    dig = n%10;
    rev = rev * 10 + dig;
    n = n/10;
}
if (temp == rev)
{    Console.WriteLine("Число является палиндромом");
}

else
{
    Console.WriteLine("Число не является палиндромом");
}   

