//Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(string number)
{
if (number[0] == number[4] &&
    number[1] == number[3])   Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Нет, это не палиндром");
}

Console.WriteLine("Введите число:");
string number = Convert.ToString(Console.ReadLine());

if (number.Length == 5) Palindrom(number);
else Console.WriteLine("Введите пятизначное число");
