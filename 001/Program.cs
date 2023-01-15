/* 1. Напишите программу, которая принимает на вход трёхзначное число и
 на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputInt("Введите трехзначное число");
if (a > 99 && a < 1000)
{
    int result = a % 10;
    Console.WriteLine("Последняя цифра числа равна " + result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
