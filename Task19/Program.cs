// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 0;
// ввод с проверкой пятизначности
while (true)
{
    number = ReadInt("Введите пятизначное число: ");
    if (number<0)
    {
        number = number*(-1);
    }
    if (number < 10000 || number > 99999)
    {
        Console.Write("Вы ввели некорректное число. ");
    }
    else
    {
        break;
    }
}

int firstTwoNumbers = number/1000;
int fifthNumber = number%10;
int helpNumber = number/10;
int forthNumber = helpNumber%10;
int checkNumber = fifthNumber*10+forthNumber;

if (firstTwoNumbers == checkNumber)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}