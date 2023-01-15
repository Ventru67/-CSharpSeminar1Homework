// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Введите число из отрезка [10, 99]: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int x = number % 10;
int y = number / 10;

if (x >= y)
{
    Console.WriteLine(x);
} 
if (x < y)
{
    Console.WriteLine(y);
} 
