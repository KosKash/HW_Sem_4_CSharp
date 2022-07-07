/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
System.Console.Write("Введите число ");
string num = Console.ReadLine();
int[] ms = new int[num.Length];
for (int i = 0; i < num.Length; i++)
{
    ms[i] = int.Parse(num[i].ToString());
}
int sum = ms.Sum();
System.Console.WriteLine(sum);

