Console.WriteLine("Введите слово: ");
string slovo=Console.ReadLine()!;
string alfavit = "йцукенгшщзхъэждлорпавыфячсмитьбюё";
int count=0;
for(int i = 0; i < alfavit.Length; i++)
{
    for(int j = 0; j < slovo.Length; j++)
    {
        if (alfavit[i] == slovo[j]) {count++;break;}

    }
} 
if (count == 33) Console.WriteLine("Слово панграмма");
else Console.WriteLine("Слово не является панграммой");