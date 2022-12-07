
/*  1. Задача. 

Console.WriteLine("Как тебя зовут? ");
string username = Console.ReadLine();
Console.WriteLine("Привет, ");
Console.WriteLine(username);
*/

// 2. Задача.

/*Console.Write("Как тебя зовут? ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.Write(username);
*/

// 3. Задача Написать программу сложения двух чисел.
/*
int numberA = 36, numberB = 5;
int result = numberA + numberB;
Console.WriteLine(result);
*/


// ------------------------Seminar 1------------------------

// Задача 1 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int guad = num2 * num2;

if(num1 == guad)
    Console.Write ("Yes! ");
else
    Console.Write ("No! ");    
*/

//Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input an integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

 //                               Dom zadanie 1 

//Задача 1.  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num2 > max)
    max = num2;
    Console.Write($"max = {max} ");
*/

//Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) 
    max = num2;
if (num3 > max) 
    max = num3;

Console.Write($"max = {max} ");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input an integer number " );
int num = Convert.ToInt32(Console.ReadLine());

if ((num % 2) == 0)
    Console.Write ("Yes! ");
else
    Console.Write ("No! ");  
*/

// Задача 7.  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= num)
{
    if(current % 2 == 0)
    Console.Write(current + " ");
    current++;
}       
*/

//-----------------------------------------Seminar2----------------------------------------------------

//1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int num)
{
    int sot = num / 100;
    int ed = num % 10;
    int result = sot * 10 + ed;
    return result;
}
int RandNum = new Random().Next(100,1000);
int newNum = CutNumber(RandNum);
Console.WriteLine($"New version of a number {RandNum} is {newNum}");
*/

//2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int MaxNum(int num)
{
    int num1 = num / 10;
    int num2 = num % 10;
    int maxnum;
    if(num1 > num2)
    {
        maxnum = num1;
    }
    else
    {
        maxnum = num2;
    }
    return maxnum;
}
int RandNum = new Random().Next(10,99);
int newnum = MaxNum(RandNum);
Console.WriteLine($"New version of a number {RandNum} is {newnum}");


//3.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.




//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
