/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет   С ИСПОЛЬЗОВАНИЕМ МЕТОДОВ*/ 

int number = ReadInt("Введите номер дня недели: ");

if(number==1 | number==2 | number==3 | number==4 | number==5)
{
    Console.WriteLine("Не выходной день");
}
else if(number==6 | number==7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}

int ReadInt(string message)  
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
