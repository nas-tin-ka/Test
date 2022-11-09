// Напишите программу, которая принимает на вход трехзначное число и на выходе 
// показывает вторую цифру этого числа
Console.Clear();
Console.WriteLine("Вывод второй цифры трехзначного числа");
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number < 99||number > 999) 
{
    Console.WriteLine("Введите корректное число!");
    //Return;
}
else 
{
    int result = number/10;
    
   Console.WriteLine($"Вторая цифра трехзначного числа: {result % 10}");
}



