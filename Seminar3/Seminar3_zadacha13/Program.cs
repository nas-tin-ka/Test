// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
// третьей цифры нет
Console.Clear();
Console.WriteLine("Вывод третьей цифры заданного числа");
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int numberTemp = number;

int lenghtOfNumber = 0;


while (number >= 1)
{
    int b = number % 10;
    number /= 10;
    lenghtOfNumber++;
}

int[] array = new int[lenghtOfNumber];

number = numberTemp;

int count = 0;

if (lenghtOfNumber < 3)
{
    Console.Write("Третьей цифры нет");
}
else
{

    while (number >= 1)
    {
        int b = number % 10;
        number /= 10;
        //Console.Write("{0:0.##} ", b);
        array[count] = b;
        count++;
    }
    //Console.WriteLine(" ");
    //Console.WriteLine("{0:0.##} ", lenghtOfNumber);
    Console.WriteLine("{0:0.##} ", array[lenghtOfNumber - 3]);
}
