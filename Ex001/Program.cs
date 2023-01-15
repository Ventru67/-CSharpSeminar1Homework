//По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

if (firstNumber == secondNumber*secondNumber)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else {
    Console.WriteLine("Первое число не является квадратом второго");
}