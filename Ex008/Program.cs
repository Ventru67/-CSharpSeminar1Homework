// Удалить вторую цифру трёхзначного числа
Console.Write("Введите трёзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int first = (number / 100) * 10;
int last = number % 10;
int result = first + last;

Console.WriteLine(result);


