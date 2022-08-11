/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1        с ИСПОЛЬЗОВАНИЕМ МЕТОДОВ */ 

int number = ReadInt("Введите трехзначное число: ");

if(number > 99 && number < 1000)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Ошибка! Вы ввели не трехзначное число");
}



int ReadInt(string message)  
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

