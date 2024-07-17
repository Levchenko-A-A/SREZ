int[,] mas = new int[5, 5];
Random random = new Random();

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = random.Next(-10, 11);
        Console.Write(mas[i, j]+" ");
    }
    Console.WriteLine();
}
for (int i = 0;i < mas.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0;j < mas.GetLength(1); j++)
    {
        sum += mas[i, j];       
    }
    Console.WriteLine(sum);
}