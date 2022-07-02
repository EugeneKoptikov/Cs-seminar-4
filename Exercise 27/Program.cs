// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Программа, принимает число и выдает сумму цифр из числа");
Console.Write("Введите число: ");
string number = Console.ReadLine();
Console.WriteLine(" ");

int index = 0;
char symbol;
int element;
int sum = 0;

while (index < number.Length)
{
    symbol = number[index];
    element = (int)Char.GetNumericValue(symbol);
    sum = sum + element;
    index++;
 
}

Console.WriteLine("Сумма цифр: " + sum);