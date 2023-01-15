// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{ 
    while (number >= 1000) number /= 10;
    {
    int result = number % 10;
    Console.WriteLine(result);
    }
}