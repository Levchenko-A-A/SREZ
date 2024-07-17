//20.Создайте одномерный массив длиной 8 элементов, вручную
//заполните его числами от -10 до 10.
//21. Найти сумму элементов в массиве.
//22. Посчитать количество четных чисел в массиве.
//23. Определить наибольший и наименьший элемент в массиве.
//24. Проверить, является ли массив “палиндромом”.
//Да да, числовой массив

int[] mas = new int[8];

Console.WriteLine("Заполненный массив:");
RandMas(mas);
PrintMas(mas);

Console.WriteLine($"Колличество четных элементов: {CountEvenNumber(mas)}");



void RandMas(int[] mas)
{
    Random random = new Random();
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = random.Next(-10, 11);
    }
}
void PrintMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + " ");
    }
}
bool IsEven(int number)
{
    if (number % 2 == 0) return true;
    else return false;
}
int CountEvenNumber(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (IsEven(mas[i])) count++;
    }
    return count;
}