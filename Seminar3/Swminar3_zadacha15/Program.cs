// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным
//6 -> да
//7 -> да
//1 -> нет


// Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if(number == 6|number == 7) Console.WriteLine("да");
else if (number>7|number<1) Console.WriteLine("Введите корректное число");
else Console.WriteLine("нет");