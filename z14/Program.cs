Console.WriteLine("Введите число: ");
int n=int.Parse(Console.ReadLine()!);
if(CheckNumber(n)) Console.WriteLine($"{n} является совершенным числом");
else Console.WriteLine($"{n} не является совершенным числом");
bool CheckNumber(int n)
{
    int sum = 1;
    for(int i = 2;i<n/2+1;i++) if(n%i==0) sum+=i;
    return (sum == n);
}