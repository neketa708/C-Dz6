/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void TriCheck(int[] arr, out int znach)
{
    znach = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0)
        {
            znach += 1;
        } else
        {
            znach += 0;
        }
    }
}

int[] ImputArray(string text)
{
    System.Console.WriteLine(text);
    return  Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}


int[] triangle = ImputArray("Input numbers");
PrintArray(triangle);
TriCheck(triangle, out int znach);
System.Console.WriteLine($"количество чисел больше 0: {znach}");