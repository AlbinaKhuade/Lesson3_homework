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

void Palindrome(int num1)
{
    int index1 = num1/10000;        // вычисляем первую цифру числа
    int index2 = num1/1000%10;      // вычисляем вторую цифру числа
    int index3 = num1/100%10;       // вычисляем третью цифру числа
    int index4 = num1/10%10;        // вычисляем четвертую цифру числа
    int index5 = num1%10;           // вычисляем пятую цифру числа
    int num2 = index5*10000 + index4*1000 + index3*100 + index2*10 + index1; // "переворачиваем" число

    if (num1 < 10000 || num1 > 99999) Console.WriteLine("Вы ввели не пятизначное число!");
    else if (num1 == num2) Console.WriteLine($"{num1} -> да");
    else Console.WriteLine($"{num1} -> нет");
}


