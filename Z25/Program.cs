//25. Создайте двумерный массив длиной 5х5 элементов, вручную
//заполните его числами от -10 до 10.

int[,] mas = new int[5, 5];
RandMasTwo(mas);
PrintMasTwo(mas);

void RandMasTwo(int[,] mas)
{
    Random random = new Random();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = random.Next(0, 11);
        }
    }
}
void PrintMasTwo(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j],4} ");
        }
        Console.WriteLine();
    }
}