// напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последннюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
    Console.WriteLine(number % 10);
else
    Console.WriteLine("Вы ввели не трехзначное число");