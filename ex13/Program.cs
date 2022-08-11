/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int number = ReadInt("Введите число: ");

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number > 99)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine(secondDigit);
}



int ReadInt(string message)  
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

