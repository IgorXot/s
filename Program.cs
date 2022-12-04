
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

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int guad = num2 * num2;

if(num1 == guad)
    Console.Write ("Yes! ");
else
    Console.Write ("No! ");    
