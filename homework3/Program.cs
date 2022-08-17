// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int x = int.Parse(numberString);
int index = 1;


while (x >=index)
{
  var result = Math.Pow(index, 3);
  index++;
  Console.WriteLine(result + " ");
  Console.WriteLine(" ");
}

if (x < 1)
  Console.WriteLine("Введены неверные значения");
