int[] mas = new int[8] { -8, -4, -2, -1, 0, 2, 5, 6 };
int min=int.MaxValue;
int max=int.MinValue;
for(int i = 0; i < mas.Length; i++)
{
    if (mas[i] < min) min = mas[i];
    if (mas[i] > max) max = mas[i];
}
Console.Write($"Минимальное число: {min} Максимальное число: {max}");