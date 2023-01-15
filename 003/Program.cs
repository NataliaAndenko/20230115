/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int a = InputInt("Введите 1 число");
int b = InputInt("Введите 2 число");
if (a % b == 0)
Console.WriteLine("Да, кратно");
else Console.WriteLine("Нет, не кратно, остаток " + a % b);
