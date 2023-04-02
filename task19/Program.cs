Console.WriteLine("Introduce un numero de 5 digitos!");
int number = int.Parse(Console.ReadLine());
int firstDigit = number / 10000;
int lastDigit = number % 10;
int fourthDigit = number / 10 % 10;
int secondDigit = 0;

while (number > 99 && number < 100000)
{
    number /=10;
}
if (number < 100)
{
    secondDigit = number % 10;
}
Console.WriteLine($"firstDigit = {firstDigit}");
Console.WriteLine($"lastDigit = {lastDigit}");
Console.WriteLine($"secondDigit = {secondDigit}");
Console.WriteLine($"fourthDigit = {fourthDigit}");

if (firstDigit == lastDigit && secondDigit == fourthDigit)
{
    Console.WriteLine("Este numero es palindrome!");
}
else
{
    Console.WriteLine("Este numero no es palindrome!");
}
