int[][] mas = new int[4][];
mas[0] = new int[4] { 7, -4, 22, -12 };
mas[1] = new int[1] { 1 };
mas[2] = new int[4] { 13, -20, -6, -9 };
mas[3] = new int[3] { 0, 16, 5 };
double result = 0;
for (int i = 0; i < mas.Length; i++)
{
    result = 0;
    for(int j = 0; j < mas[i].Length; j++)
    {
        result += mas[i][j];
    }
    Console.WriteLine($"Среднее арифметическое {i+1} массива: {result / mas[i].Length}");
}