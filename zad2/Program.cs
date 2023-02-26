/*Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void TriCheck(int[] arr, out double y, out double y1)
{
    double x=-(arr[1]-arr[3]);
    double z=arr[0]-arr[2];
    y=z/x;
    y1=arr[3]*y+arr[2];
}

int[] ImputArray(string number)
{
    System.Console.WriteLine(number);
    return  Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}


int[] triangle = ImputArray("введите 4 числа");
PrintArray(triangle);
TriCheck(triangle, out double y, out double y1);
System.Console.WriteLine($"пересечения первой прямой {y} пересечения второй прямой {y1}");