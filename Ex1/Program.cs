/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.Clear();
System.Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
System.Console.Write("Введите степень в которую хотите возвести число ");
int st = int.Parse(Console.ReadLine());
int num1 = num;
for (int i = 1;  i < st; i++)
{
    num = num * num1;
}
System.Console.WriteLine(num);

