// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите кратное число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите делитель: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

int remainder = firstNumber % secondNumber;
if (firstNumber < secondNumber) 
{
    Console.WriteLine("Кратное должно быть больше делителя");
}
else if (remainder == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else {
    Console.WriteLine("Второе число не кратно первому, остаток: " + remainder);
}