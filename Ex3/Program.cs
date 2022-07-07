/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Оформите программу ввиде функций (пригодится в дальнейшем)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
void CreaArray(int[] array)
{
    int len = array.Length;
    for (int index = 0; index < len; index++)
    {
        array[index] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    System.Console.Write("[");
    System.Console.Write(arr[0]);
    for (int pos = 1; pos < count; pos++)
    {
        System.Console.Write($", {arr[pos]}");
    }
    System.Console.Write("]");

}

int[] array1 = new int[8];

CreaArray(array1);
PrintArray(array1);