// Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Введите число: ");
int number=int.Parse(Console.ReadLine());

if(IsPldr(number)) 
    Console.WriteLine($"Число {number} является палиндромом.");
else
    Console.WriteLine($"Число {number} НЕ является палиндромом.");

bool IsPldr(int num)
{
    int numcopy=num, reversed=0;

    while (numcopy!=0)
    {
        reversed=reversed*10+numcopy%10;
        numcopy/=10;
    }
    if(reversed==num) return true;
    else return false;
}

