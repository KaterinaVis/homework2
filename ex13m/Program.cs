/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 *  C ИСПОЛЬЗОВАНИЕМ МЕТОДА */


string numbertext = ReadString("Введите число: ");

if (numbertext.Length > 2)
{
 Console.Write("Третья цифра числа " + numbertext[2]);
}
else
{
    Console.Write("В этом числе третьей цифры нет");
}


string ReadString(string message)  
{
Console.Write(message);
return Convert.ToString(Console.ReadLine());
}