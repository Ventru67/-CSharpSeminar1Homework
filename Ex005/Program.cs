// Показать последнюю цифру трёхзначного числа
Console.Write("Введите трёзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int result = number % 10;
Console.WriteLine(result);