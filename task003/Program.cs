// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// void Main()
// {
//     Console.Clear();
//     int number = GetNumber();
//     int[] result = InBinary(number);
//     WriteArray(RevArray(result));
// }

// int GetNumber()
// {
//     Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }

// int[] InBinary(int number)
// {
//     int i = 0;
//     int a = 0;
//     int[] array = new int[0];
//     while (number >= 1)
//     {
//         Array.Resize(ref array, array.Length + 1);
//         a = number % 2;
//         array[i] = a;
//         i++;
//         number = number / 2;
//     }
//     return array;
// }

// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int[] RevArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int k = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = k;
//     }
//     return array;
// }

// Main();


Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
DecimalToBinaryConversion(a);
void DecimalToBinaryConversion(int a)
{
    string b = "1";
    while (a > 0)
    {
        b = (a % 2) + b;
        a = a / 2;
    }
    Console.Write(b);
}
