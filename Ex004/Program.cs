// Показать четные числа от 1 до N
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int nextNumber = 1;

while (nextNumber <= number)
{
    if (nextNumber % 2 == 0)
        Console.WriteLine(nextNumber);
        nextNumber++; 
}
