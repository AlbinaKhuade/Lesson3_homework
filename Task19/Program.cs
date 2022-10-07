// Задача 19
// Напишите программу, которая
// принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);

void Palindrome(int num)
{
    int index1 = num/10000;     // вычисляем первую цифру числа
    int index2 = num/1000%10;   // вычисляем вторую цифру числа
    int index3 = num/100%10;    // вычисляем третью цифру числа
    int index4 = num/10%10;     // вычисляем четвертую цифру числа
    int index5 = num%10;        // вычисляем пятую цифру числа
    
    if (num < 10000 || num > 99999) Console.WriteLine("Вы ввели не пятизначное число!");
    else if (index1 == index5 && index2 == index4) Console.WriteLine($"{num} -> да");
    else Console.WriteLine($"{num} -> нет");
}


