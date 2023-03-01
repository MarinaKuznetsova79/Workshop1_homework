//int num1 = 25;
//double num2 = 13.45;
//string word = "Pavel";
//char symbol = '%';
//bool check = word.Length > "Pavel.Length";

//Console.WriteLine("Hello,World!");
/*
int num1 = 25;
int num2 = 40;

string word = "Pavel";
char symbol = '%';
bool check = true;

Console.WriteLine("my number are " + num1 + " and " + num2 + " and it is good!");
операция конкотинация



int num1 = 25;
int num2 = 40;

Console.WriteLine($"my number are {num1} and {num2} and it is good!");
*/
/* Не будет работать ВАЖНО
Console.Write("Input a number:");
Console.WriteLine ()
*
Console.Write("Input a number:");
int number = Console.ReadLine();
*/
/*
Console.Write("Input a number:");
int number = Convert.ToInt32(Console.ReadLine());
# ЗАПРОС ДАННЫХ ЗАПОМНИТЬ

*******Задача1*********************

Напишите программу которая на вход принимает два числа 
и проверяет является ли первое число квадратом  второго числа ?
1. Запрос 2х переменных

Console.Write("Input a first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if(number1 == quad2) 
{
   Console.WriteLine("Yes!");
}
else
{
  Console.WriteLine("No!");
}
//# Можно делать без {} тоже будет верно

Console.Write("Input a first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

int quad2 = number2 * number2;

if(number1 == quad2)                  // ЗАПОМНИТЬ в блоке не ставится (;) 
   Console.WriteLine("Yes!");
else
  Console.WriteLine("No!");

**********Задача 2***************
Написать программу которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке 
от отрицательной версии этого числа (-N) до положительного (N)?
Логическая конструкция :
ветвление и цикл

Console.Write("Input a positive number:");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;   // индекс цикл каррент

while(current <= num)  // нестрогое неравенство
{
  Console.Write(current + " ");
  current++;             // итерация увеличить изменить (-,+,/,*) переменную  current = current +2; или current + = 2;

}
//*
34215 / 10 = 3421
34215 / 100 = 342
34215 / 1000 = 34
34215 / 10000 = 3

34215 % 10 = 5
34215 % 100 = 15
34215 % 1000 = 215
34215 % 10000 = 4215

23456 -> 34 
28563 -> 56 деление на 10 % 100
